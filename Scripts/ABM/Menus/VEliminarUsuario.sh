#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh" 

VMenuEliminarUsuario() {
    #region [rgba(170, 160, 26, 0.10)] variables 
    local continuar=true
    usuarioAEliminar=""
    abrirSeleccionarGrupo=false
    #endregion
    
    #region [rgba(27, 173, 192, 0.10)] tui 

    iniciarPantallaNueva
    dibujarTxt "ELIMINAR USUARIO" 43 3 0

    dibujarTxt "INGRESA EL USUARIO" 38 11 0 
    dibujarEntradaTxt 38 12 20 false

    dibujarBoton "SIGUIENTE" 14 18 40 3 
    dibujarBoton "VOLVER" 53 18 40 3
    
    #endregion

    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in 

            "0")
                if $modificado;
                then
                    usuarioAEliminar=$respuestaGestor                
                fi

                ;;

            "1")
                if $respuestaGestor; 
                then
                    if [ $(grep -E "^$usuarioAEliminar:" /etc/passwd) ]; 
                    then # busca el usuario en la lista de usuarios del sistema
                        continuar=false
                        abrirSeleccionarGrupo=true
                    fi
                fi
                ;;

            "2")
                if $respuestaGestor; 
                then
                    continuar=false
                fi
                ;;

        esac
    done
}

ejecutarEliminarUsuario() {

    local continuar=true 

    while $continuar; 
    do
        VMenuEliminarUsuario

        if $abrirSeleccionarGrupo; 
        then
            ejecutarElegirGrupo

            if [ $(grep -E "^$usuarioAEliminar:.*::/home/USUARIOS/$grupoPerteneciente/$usuarioAEliminar" /etc/passwd) ]; 
            then
                if [ $(borrarUsuario $usuarioAEliminar) = "0" ]; 
                then
                    VAvisoRegistrado "Usuario eliminado correctamente" 10 
                else
                    VAvisoRegistrado "Necesita permisos para borrar usuarios" 9 
                fi
            else 
                VAvisoRegistrado "Usuario inexistente o el grupo no fue el correspondiente" 9 
            fi
        else
            continuar=false
        fi
    done

    cerrarPantalla
}