#!/bin/bash

. "/Scripts/InterfazGrafica/Vista/ElementosPredeterminados/ventana.sh"


dibujarSwitch() {   
    #region [rgba(47, 0, 255, 0.10)] args
    # -Carga switch y guarda los datos en una lista-
    # $1 : es el inicio de la entrada de texto en x
    # $2 : es el inicio de la entrada de texto en y
    # $3 : largo del switch
    # $4 : ancho del switch
    # $5 : estado inicial {true o false}
    # $6 : color encendido {opcional}
    # $7 : color apagada  {opcional}
    #endregion

    let colorEncendido=2
    let colorApagado=1

    if [ "$6" ]; 
    then
        colorEncendido=2
    fi

    if [ "$7" ]; 
    then
        colorApagado=1
    fi

    cargarSwitch "$1" $2 $3 $4 $colorEncendido $colorApagado "$5" # color FG pasa a ser color cuando se apaga
    agregarUbicacion "SWITCH" "$5" $1 $2 $3 $4 $colorEncendido $colorApagado 
}

dibujarBoton(){
    #region [rgba(47, 0, 255, 0.10)] args
    # -Carga boton en pantalla y guarda los datos en una lista--
    # $1 : el texto del boton
    # $2 : es el inicio de la entrada de texto en x
    # $3 : es el inicio de la entrada de texto en y
    # $4 : largo del boton
    # $5 : ancho del boton
    # $6 : color background 
    # $7 : color foreground
    #endregion
    let colorBg=4      
    let colorFg=7   

    if [ "$6" ]; 
    then
        colorBg=$6
    fi

    if [ "$7" ]; 
    then 
        colorFg=$7
    fi

    cargarBoton "$1" $2 $3 $4 $5 $6 $colorBg $colorFg 
    agregarUbicacion "BTN" "$1" $2 $3 $4 $5 $colorBg $colorFg
}

dibujarTxt() {
    #region [rgba(47, 0, 255, 0.10)] args
    # -Muestra un texto en pantalla y guarda los datos en una lista-
    # $1 el texto a imprimir
    # $2 es el inicio de la entrada de texto en x
    # $3 es el inicio de la entrada de texto en y 
    # $4 color foreground {opcional}
    # $5 color background {opcional}

    #endregion
    let colorFg=7
    let colorBg=$colorBgDefecto

    if [ "$4" ]; 
    then 
        colorFg=$4
    fi

    if [ "$5" ]; 
    then
        colorBg=$5
    fi
    tput cup $3 $2
    tput setaf $colorFg
    tput setab $colorBg

    echo -n "$1"

}

dibujarEntradaTxt() { 
    #region [rgba(47, 0, 255, 0.10)] args
    # -Muestra una entrada de texto y guarda los datos en una lista-
    # $1 : es el inicio de la entrada de texto en x 
    # $2 : es el inicio de la entrada de texto en y 
    # $3 : es el largo de la entrada 
    # $4 : int es password
    # $5 : texto por defecto {opcional}

    #endregion

    let colorBg=0 
    let colorFg=5
            
    if $4; 
    then
        agregarUbicacion "PWTXT" "$5" $1 $2 $3 1 $colorBg $colorFg 
    else
        agregarUbicacion "INPTXT" "$5" $1 $2 $3 1 $colorBg $colorFg 
    fi
    cargarEntradaTxt $1 $2 $3 1 $colorBg $colorFg "$5"

}
