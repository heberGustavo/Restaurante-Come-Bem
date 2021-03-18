﻿//Efeito Ancora
$(document).on(
    "click",
    'a[href="#home"], a[href="#sorteio-em-andamento"]', function (e) {

    var target = $(this).attr("href"); //Get the target
    var scrollToPosition = $(target).offset().top - 70;

    $('html,body').animate({ 'scrollTop': scrollToPosition }, 1000, function () {

    });
    window.location.hash = target;

    e.preventDefault();

    //Remove o nome da ancora da url
    history.replaceState("", null, window.location.pathname);
});

$(function () {

    $('#sidebarCollapse').on('click', function () {
        $('#sidebar, #content').toggleClass('active');
    });

});