var windowUrl = window.location.href.toLowerCase();
//alert("windowUrl");
$('.nav li').removeClass('active');
$('.nav li').each(function (index) {
    pageUrl = $(this).find('a').attr('href')
    if (windowUrl.indexOf(pageUrl) > -1) {
        $(this).addClass('active');
    }
});
setTimeout(function () {
    $(".loading_main_background").hide('100');
}, 100);

//setTimeout(function () {
//    $(".preloader-back-bc").fadeOut('500');
//}, 800);
//setTimeout(function () {
//    $("#processing_pageloader").hide('500');
//}, 500);

$(document).ready(function () {
    $("#reset_user_yes").click(function () {
        $("#processing_pageloader").fadeIn("500");
    })
})


//.delay("1000").fadeOut("500")
//processing_pageloader

//students details tab tree

//mouse movement js

//$(function () {

//    $(".auto-form-wrapper").css({ "position": "absolute", "top": "16px", "left": "960px", "cursor": "move" })

//    var dragging = false;
//    var iX, iY;
//    $(".auto-form-wrapper").mousedown(function (e) {
//        dragging = true;
//        iX = e.clientX - this.offsetLeft;
//        iY = e.clientY - this.offsetTop;
//        this.setCapture && this.setCapture();
//        return false;
//    });
//    document.onmousemove = function (e) {
//        if (dragging) {
//            var e = e || window.event;
//            var oX = e.clientX - iX;
//            var oY = e.clientY - iY;
//            $(".auto-form-wrapper").css({ "left": oX + "px", "top": oY + "px" });
//            return false;
//        }
//    };
//    $(document).mouseup(function (e) {
//        dragging = false;
//        $(".auto-form-wrapper")[0].releaseCapture();
//        e.cancelBubble = true;
//    })
//})


//End mouse movement js