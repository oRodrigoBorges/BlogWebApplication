﻿// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function () {
    var menuIcon = document.querySelector('.iconeMenu');
    var menuLateral = document.getElementById('menuLateral');
    var sobreposição = document.getElementById('sobreposição');
    var fecharMenu = document.getElementById('fecharMenu');

    menuIcon.addEventListener('click', function () {
        menuLateral.classList.add('active');
        sobreposição.classList.add('active');
    });

    fecharMenu.addEventListener('click', function () {
        menuLateral.classList.remove('active');
        sobreposição.classList.remove('active');
    });

    sobreposição.addEventListener('click', function () {
        menuLateral.classList.remove('active');
        sobreposição.classList.remove('active');
    });
});

let fontSize = 16;

function modificaTamanhoDaFonte(valorAlteracao) {
    fontSize += valorAlteracao;
    document.body.style.fontSize = fontSize + 'px';
}

function resetaTamanhoDaFonte() {
    fontSize = 16;
    document.body.style.fontSize = fontSize + 'px';
}