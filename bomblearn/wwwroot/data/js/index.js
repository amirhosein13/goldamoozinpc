var boolpayeeneshowshode = false;
var boolbalashowshode = true;
var boolvasatshowshode = false;
var boolvasatpayeenshowshode = false;

$(window).resize(function () {
    $(".imagewidthjs").height($(".imagewidthjs").width() / 4 * 3);
    $(".imagewidthjsa").height($(".imagewidthjsa").width() / 4 * 3);
});
$(".imagewidthjs").height($(".imagewidthjs").width() / 4 * 3);



$(".khodeiconbalanavbar")
    .transition('fade down')
    ;
$(".animationlinkhayebala1")
    .transition('fade left')
    ;
$(".animationlinkhayebala2")
    .transition('fade right')
    ;
$(".animationlinkhayebala3")
    .transition('fade up')
    ;
$(".animationlinkhayebala4")
    .transition('fade down')
    ;
$(".animationlinkhayebala5")
    .transition('fade left')
    ;
setTimeout(function () {
    $(".matnbalabalayeesh")
        .transition('fly left')
        ;
    $(".matnbalapayeenish")
        .transition('fly right')
        ;
    $(".btnbalabalayee")
        .transition('fly up')
        ;
    $(".aksbalabalayee")
        .transition('fly down')
        ;
    $(".imagewidthjsa").height($(".imagewidthjsa").width() / 4 * 3);
}, 250);
$(window).scroll(function () {
    console.log($(window).scrollTop());
    var a = $("#sec1").height();
    var b = $("#sec2").height();
    var c = $("#sec3").height();
    var d = $("#sec4").height();
    var e = $("#sec5").height();
    var f = $("#sec6").height();




    if ($(window).scrollTop() >= a + b - 300 && boolpayeeneshowshode == false && $(window).scrollTop() < a + b + c - 250) {
        $(".matnbalapayeenishbala")
            .transition('fly left')
            ;
        $(".matnbalapsyeenyshpayeenish")
            .transition('fly right')
            ;
        $(".btnbalabalapayeeny")
            .transition('fly down')
            ;
        $(".aksbalapayeenysh")
            .transition('fly up')
            ;
        boolpayeeneshowshode = true;
    }




    if (boolbalashowshode == false && $(window).scrollTop() < a + b - 100) {
        $(".matnbalabalayeesh")
            .transition('fly left')
            ;
        $(".matnbalapayeenish")
            .transition('fly right')
            ;
        $(".btnbalabalayee")
            .transition('fly down')
            ;
        $(".aksbalabalayee")
            .transition('fly up')
            ;
        boolbalashowshode = true;
    }




    if ($(window).scrollTop() >= a + b + c - 300 && boolvasatshowshode == false && $(window).scrollTop() < a + b + c + d - 200) {
        $(".imgvasatasly")
            .transition('fly left')
            ;
        $(".h2vasatasly")
            .transition('fly right')
            ;
        $(".avalinmethodvasat")
            .transition('fly down')
            ;
        $(".dovominmethodvasat")
            .transition('fly up')
            ;
        $(".sevominmethodvasat")
            .transition('fly right')
            ;
        $(".chaharominmethodvasat")
            .transition('fly left')
            ;
        boolvasatshowshode = true;
    }


    if (boolvasatpayeenshowshode == false && $(window).scrollTop() > a + b + c + d - 300) {
        $(".h2vasatpayeenbalash")
            .transition('fly left')
            ;
        $(".h2vasatpayeenvasatesh")
            .transition('fly right')
            ;
        $(".btnvasatpayeenees")
            .transition('fly down')
            ;
        boolvasatpayeenshowshode = true;
    }
});


$(".btnclicksidebar").click(function () {
    $('.ui.sidebar')
        .sidebar('toggle')
        ;
});



















// var boolpayeeneshowshodea=false;
// var boolbalashowshodea=true;
// var boolvasatshowshodea=false;
// var boolvasatpayeenshowshodea=false;

// $(".khodeiconbalanavbaraa")
//   .transition('fade down')
// ;
// $(".animationlinkhayebala1a")
//   .transition('fade left')
// ;
// $(".animationlinkhayebala2a")
//   .transition('fade right')
// ;
// $(".animationlinkhayebala3a")
//   .transition('fade up')
// ;
// $(".animationlinkhayebala4a")
//   .transition('fade down')
// ;
// $(".animationlinkhayebala5a")
//   .transition('fade left')
// ;
// setTimeout(function(){
//     $(".matnbalabalayeesha")
//     .transition('fly left')
//   ;
//   $(".matnbalapayeenisha")
//     .transition('fly right')
//   ;
//   $(".btnbalabalayeea")
//     .transition('fly up')
//   ;
//   $(".aksbalabalayeea")
//     .transition('fly down')
//   ;
//   },250);
// $(window).scroll(function () { 
//   var getscrolltopads=$(window).scrollTop();
//   console.log($(window).scrollTop());
//   var aa=$("#sec1").height();
//   var bb=$("#sec2a").height();
//   var cc=$("#sec3a").height();
//   var dd=$("#sec4a").height();

//   if($(window).scrollTop()>=aa+bb-300&&boolpayeeneshowshodea==false&&$(window).scrollTop()<aa+bb+cc-250){
//     $(".matnbalapayeenishbalaa")
//     .transition('fly left')
//   ;
//   $(".matnbalapsyeenyshpayeenisha")
//     .transition('fly right')
//   ;
//   $(".btnbalabalapayeenya")
//     .transition('fly down')
//   ;
//   $(".aksbalapayeenysha")
//     .transition('fly up')
//   ;
//   boolpayeeneshowshodea=true;
//   }

//  if(boolbalashowshodea==false&&$(window).scrollTop()<aa+bb-100){
//     $(".matnbalabalayeesha")
//     .transition('fly left')
//   ;
//   $(".matnbalapayeenisha")
//     .transition('fly right')
//   ;
//   $(".btnbalabalayeea")
//     .transition('fly down')
//   ;
//   $(".aksbalabalayeea")
//     .transition('fly up')
//   ;
//   boolbalashowshodea=true;
//   }




//   if($(window).scrollTop()>=aa+bb+cc-300&&boolvasatshowshodea==false&&$(window).scrollTop()<aa+bb+cc+dd-200){
//     $(".imgvasataslya")
//     .transition('fly left')
//   ;
//   $(".h2vasataslya")
//     .transition('fly right')
//   ;
//   $(".avalinmethodvasata")
//     .transition('fly down')
//   ;
//   $(".dovominmethodvasata")
//     .transition('fly up')
//   ;
//   $(".sevominmethodvasata")
//     .transition('fly right')
//   ;
//   $(".chaharominmethodvasata")
//     .transition('fly left')
//   ;
//   boolvasatshowshodea=true;
//   }

//   if(boolvasatpayeenshowshodea==false&&$(window).scrollTop()>aa+bb+cc+dd-300){
//     $(".h2vasatpayeenbalasha")
//     .transition('fly left')
//   ;
//   $(".h2vasatpayeenvasatesha")
//     .transition('fly right')
//   ;
//   $(".btnvasatpayeeneesa")
//     .transition('fly down')
//   ;
//   boolvasatpayeenshowshodea=true;
//   }
//   $(window).scrollTop(getscrolltopads);
// });
$(".btnclicksidebara").click(function () {
    $('.ui.sidebar')
        .sidebar('toggle')
        ;
});























