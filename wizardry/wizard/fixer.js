

$(document).ready(function () {
    $(".btn1").click(function () {
        $("p").hide(2000);
    });
    $(".btn2").click(function () {
        $("p").show(3000);
    });



});

$(".flat").click(function () {
    $("#div1").fadeIn();
    $("#div2").fadeIn("slow");
    $("#div3").fadeIn(3000);
});

$(".b2").click(function () {
    $("#div1").fadeOut();
    $("#div2").fadeOut("slow");
    $("#div3").fadeOut(3000);
});

$("button").click(function () {
    $("#p1").css("color", "red").slideUp(2000).slideDown(2000);
});


function feel() {

    var store = document.getElementById('real').value;

    document.getElementById('work').innerHTML = ("hello world...you typed  " + store);



};