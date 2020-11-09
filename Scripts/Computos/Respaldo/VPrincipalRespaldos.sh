#!/bin/bash
#region imports
. "/Scripts/InterfazGrafica/Control/inicio.sh" 

. "/Scripts/Computos/Respaldo/VRespaldarBD.sh"
. "/Scripts/Computos/Respaldo/VRespaldarDirectorios.sh"
#endregion

#necesita root
PrincipalRespaldos() {
    local continuar=true
    
    #region [rgba(27, 173, 192, 0.10)] tui 
    iniciarPantallaNueva
    dibujarTxt "RESPALDOS" 46 3 0

    dibujarTxt "4 -> ARRIBA" 11 5 0
    dibujarTxt "5 -> ENTER " 11 6 0
    dibujarTxt "6 -> ABAJO" 11 7 0

    if [ $EUID -eq 0 ];
	then #root
        dibujarBoton "BASE DE DATOS" 11 8 80 3 #root
        dibujarBoton "DIRECTORIOS" 11 11 80 3 #root
        dibujarBoton "RESTAURAR BD" 11 14 80 3 #????
        dibujarBoton "RESTAURAR DIRECTORIOS" 11 17 80 3 #????
        dibujarBoton "VOLVER" 11 20 80 3
    else
        dibujarBoton "RESTAURAR BD" 11 8 80 3 #????
        dibujarBoton "RESTAURAR DIRECTORIOS" 11 11 80 3 #????
        dibujarBoton "VOLVER" 11 14 80 3
    fi
    #endregion

    while $continuar; 
    do
        siguientePos

        if $respuestaGestor; 
        then
            continuar=false
        fi 

    done

}

ejecutarRespaldos() {

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        PrincipalRespaldos
        
        case $texto in 

            "BASE DE DATOS")
                ejecutarRespaldarBD
                ;;

            "DIRECTORIOS")
                ejecutarRespaldarDirectorio
                ;;

            "RESTAURAR BD")
                # En construcción
                mensajeError "SECCION RESTAURAR BD EN CONSTRUCCION" 1 37 33 2 3 1 1
                ;;

            "RESTAURAR DIRECTORIOS")
                # En construcción
                mensajeError "SECCION RESTAURAR DIRECTORIOS EN CONSTRUCCION" 1 37 33 2 3 1 1
                ;;
                
            "VOLVER")
                continuarCiclo=false
                ;;

            *)
                ;;
        esac
        cerrarPantalla

    done

}