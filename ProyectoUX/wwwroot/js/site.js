function ScrollDiv(btn, claseCategoria) {
    var div = btn.getAttribute("target");
    var direccion = btn.getAttribute("direction");
    var ubicacion = $("#" + div).scrollLeft();
    var movimiento = direccion == 'right' ? +1200 : -1200;
    $("#" + div).scrollLeft(ubicacion + movimiento);
    $("#" + div).animate({
        scrollLeft: ubicacion + movimiento
    }, "slow");
}
