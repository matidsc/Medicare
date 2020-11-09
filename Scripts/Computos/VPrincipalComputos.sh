#!/bin/bash

#region imports
. "/Scripts/InterfazGrafica/Control/inicio.sh"

. "/Scripts/ABM/Menus/VPrincipalMenuUsuarios.sh"
. "/Scripts/Computos/Respaldo/VPrincipalRespaldos.sh"
. "/Scripts/Computos/Logs/VLogs.sh"
. "/Scripts/Computos/Procesos/VAccionesProcesos.sh"
. "/Scripts/Computos/Servicios/VPrincipalMenuServicios.sh"
. "/Scripts/Computos/Servicios/VConexiones.sh"
. "/Scripts/Computos/Iptables/VPrincipalRedes.sh"
. "/Scripts/Computos/MySQL/configMySQL.sh"
. "/Scripts/Computos/FTP/MPrincipalFTP.sh"
#endregion

PrincipalComputos() {

    local continuar=true
    
    #region [rgba(27, 173, 192, 0.10)] tui 

    iniciarPantallaNueva
    dibujarTxt "CENTRO DE COMPUTOS" 43 3 0

    dibujarTxt "4 -> ARRIBA" 11 3 0
    dibujarTxt "5 -> ENTER " 11 4 0
    dibujarTxt "6 -> ABAJO" 11 5 0
    
    dibujarBoton "USUARIOS" 11 6 80 3
    dibujarBoton "SERVICIOS" 11 9 80 3
    dibujarBoton "PROCESOS" 11 12 80 3
    dibujarBoton "IPTABLES" 11 15 80 3
    dibujarBoton "COMPROBAR RED" 11 18 80 3
    dibujarBoton "LOGS" 11 21 80 3
    dibujarBoton "RESPALDOS" 11 24 80 3
    dibujarBoton "MYSQL" 11 27 80 3
    dibujarBoton "FTP" 11 30 80 3 # solo root
    dibujarBoton "VOLVER" 11 33 80 3

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

ejecutarComputos() {

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        PrincipalComputos
        case $posDeEsteElemento in 

            "0")
                ejecutarUsuario
                ;;

            "1")
                ejecutarMenuPrincipalServicios 
                ;;
                
            "2")
                ejecutarProcesos
                            
                ;;

            "3")
                ejecutarPrincipalRed
                ;;

            "4")
                comprobarRed
                ;;

            "5") 
                ejecutarLogs                
                ;;

            "6") 
                ejecutarRespaldos
                ;;

            "7")
                ejecutarMysql
                ;;

            "8")
                ejecutarFTP
                ;;
            "9")
                continuarCiclo=false
                ;;
                  
            *)
                ;;
        esac
        cerrarPantalla

    done

}
comprobarRed () {

    if ping -c1 8.8.8.8 &>/dev/null;
    then
        mensajeError "SE DETECTÓ CONEXIÓN A INTERNET" 2 37 33 2 2 2
    else
        mensajeError "NO SE DETECTÓ CONEXIÓN A INTERNET" 1 37 33 2 1 2
    fi

}
probarFuncionEjecucionLocal ejecutarComputos "VPrincipalComputos.sh"
