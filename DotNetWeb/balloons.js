//didn't use arraylist but could be better if I did
//var animateList = [1, 2, 3, 4];

var headingTag = document.getElementsByTagName("h1");
var headingAnimation = "";

window.onload = randomAnimate();


$(function () {

    $('#birthday').pickadate({ format: 'mmmm, d' });

    // uncheck all checkboxes (FireFox)
    $('.form-check-input').each(function () {
        $(this).prop('checked', false);
    });

    // event listener for check/uncheck
    $('.form-check-input').on('change', function () {
        // make the image visible
        $('#' + this.id + 'Img').css('visibility', 'visible')
        // animate balloon in/out based on checkbox
        $(this).is(':checked') ?
            $('#' + this.id + 'Img').removeClass().addClass('animate__animated animate__bounceInDown') :
            $('#' + this.id + 'Img').addClass('animate__animated animate__bounceOutUp');
    });

    $('.form-check-input, .form-check-label').hover(function () {

        var colorID = $(this).siblings(".form-check-input").attr('id');

        $(headingTag).css('color', colorID);

        $('.form-check-input, .form-check-label').mouseleave(function () {
            $(headingTag).css('color', 'slategray');
        })
    })

    $('#checkUncheckAll').on('click', function () {
        var redCheckBox = $("#red").is(':checked');
        var greenCheckBox = $("#green").is(':checked');
        var blueCheckBox = $("#blue").is(':checked');

        if (!redCheckBox || !greenCheckBox || !blueCheckBox) {
            allChecked();
        }else{
            allUnchecked();
        }
    })

    $('#submit').on('click', function () {
        var redCheckBox = $("#red").is(':checked');
        var greenCheckBox = $("#green").is(':checked');
        var blueCheckBox = $("#blue").is(':checked');

        if (!redCheckBox && !greenCheckBox && !blueCheckBox) {
            $('#toast').toast({ autohide: false }).toast('show');
        }
    });

});

function randomAnimate() {
    var randomNum = Math.floor(Math.random() * 4) + 1;

    switch (randomNum) {
        case 1:
            headingAnimation = "animate__animated animate__heartBeat";
            break;

        case 2:
            headingAnimation = "animate__animated animate__bounce";
            break;

        case 3:
            headingAnimation = "animate__animated animate__rubberBand";
            break;

        case 4:
            headingAnimation = "animate__animated animate__tada";
            break;
    }
    $(headingTag).addClass(headingAnimation);
}

function allChecked(){
    $('.form-check-input').each(function () {
        $(this).prop('checked', true);

        $('#' + this.id + 'Img').css('visibility', 'visible')
        // animate balloon in/out based on checkbox
        $(this).is(':checked') ?
            $('#' + this.id + 'Img').removeClass().addClass('animate__animated animate__bounceInDown') :
            $('#' + this.id + 'Img').addClass('animate__animated animate__bounceOutUp');
    });
}

function allUnchecked(){
    $('.form-check-input').each(function () {
        $(this).prop('checked', false);

        $('#' + this.id + 'Img').css('visibility', 'visible')
        // animate balloon in/out based on checkbox
        $(this).is(':checked') ?
            $('#' + this.id + 'Img').removeClass().addClass('animate__animated animate__bounceInDown') :
            $('#' + this.id + 'Img').addClass('animate__animated animate__bounceOutUp');
    });
}