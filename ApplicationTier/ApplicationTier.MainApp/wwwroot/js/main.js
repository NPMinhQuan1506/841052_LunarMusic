"use strict";

/*----------------- parallax -------------------*/
function moveParallax(e) {
    var a, i, t, o = jQuery(e).visible(!0);
    if (o) {
        var n = jQuery(e).data("imagewidth"),
            r = jQuery(e).data("imageheight"),
            l = jQuery(e).data("speed"),
            s = jQuery(e).width(),
            d = jQuery(e).offset().left,
            c = jQuery(window).width(),
            u = jQuery(window).height();
        n && c - 200 > s ? (a = d - Math.round(c / 2) + Math.round(s / 2), i = Math.round((n - c) / 2), i = a + -i + "px") : i = "50%", t = r && r > u ? Math.ceil((r - u) / 2) : "0", l || (l = .3);
        var h = parseInt(jQuery(e).offset().top),
            f = h - jQuery(window).scrollTop(),
            v = f * l - t,
            l = i + " " + v + "px";
        jQuery(e).css({
            backgroundPosition: l
        })
    }
}

/*----------------- rev slider -------------------*/
function mainBanner() {
    if ($("#rev_slider").length > 0) {
        var e;
        $(document).ready(function() {
            e = jQuery("#rev_slider").revolution({
                sliderType: "standard",
                sliderLayout: "fullscreen",
                dottedOverlay:"none",
                delay:4000,
                navigation: {
                keyboardNavigation:"off",
                keyboard_direction: "horizontal",
                mouseScrollNavigation:"off",
                            mouseScrollReverse:"default",
                onHoverStop:"off",
                arrows: {
                    style:"mixtape",
                    enable:true,
                    hide_onmobile:true,
                    hide_under:1025,
                    hide_onleave:false,
                    tmp:'',
                    left: {
                        h_align:"left",
                        v_align:"center",
                        h_offset:20,
                        v_offset:0
                    },
                    right: {
                        h_align:"right",
                        v_align:"center",
                        h_offset:20,
                        v_offset:0
                    }
                }
                ,
                bullets: {
                    enable:true,
                    hide_onmobile:false,
                    hide_over:1024,
                    style:"mixtape",
                    hide_onleave:false,
                    direction:"horizontal",
                    h_align:"center",
                    v_align:"bottom",
                    h_offset:0,
                    v_offset:20,
                    space:10,
                    tmp:''
                }
            },
                responsiveLevels:[1920,1600,778,480],
                visibilityLevels:[1920,1600,778,480],
                gridwidth:[1300,800,600,300],
                gridheight:[700,600,800,500],
                lazyType:"none",
            parallax: {
                type:"mouse",
                origo:"enterpoint",
                speed:400,
                speedbg:0,
                speedls:0,
                levels:[5,10,15,20,25,30,35,40,45,46,47,48,49,50,51,55],
            },
            shadow:0,
            spinner:"off",
            stopLoop:"off",
            stopAfterLoops:-1,
            stopAtSlide:-1,
            shuffle:"off",
            autoHeight:"off",
            fullScreenAutoWidth:"on",
            fullScreenAlignForce:"off",
            fullScreenOffsetContainer: ".touch .qodef-mobile-header",
            fullScreenOffset: "",
            disableProgressBar:"on",
            hideThumbsOnMobile:"off",
            hideSliderAtLimit:0,
            hideCaptionAtLimit:0,
            hideAllCaptionAtLilmit:0,
            startWithSlide:0,
            debugMode:false,
            fallbacks: {
                simplifyAll:"off",
                nextSlideOnWindowFocus:"off",
                disableFocusListener:false,
            }
            })
        })
    }
}

function mainBanner2() {
	 if ($("#slider1").length > 0) {
        $(window).on('scroll', function () {
                if($(window).scrollTop() >= 85 ){
                    if ($("#slider1.dk").length > 0) {
                    }else{
                       $('.navbar-brand img').attr('src', 'http://rosettichefs.com/jelly/theOne/mansonv2/assets/img/demo/logos/logo-slider-black.png'); 
                    }
                    
                }else{
                     if($(window).width()<1025){
                         if ($("#slider1.dk").length > 0) {
                             $('.navbar-brand img').attr('src', 'http://rosettichefs.com/jelly/theOne/mansonv2/assets/img/demo/logos/logo-slider-white.png');
                         }else{
                            $('.navbar-brand img').attr('src', 'http://rosettichefs.com/jelly/theOne/mansonv2/assets/img/demo/logos/logo-slider-black.png');
                        }
                    }else{
                        $('.navbar-brand img').attr('src', 'http://rosettichefs.com/jelly/theOne/mansonv2/assets/img/demo/logos/logo-slider-white.png');
                    }
                }
             });
        var e;
		$(document).ready(function() {
		    e = jQuery("#slider1").revolution({
			        sliderType: "standard",
			        jsFileLocation: "../assets/revolution/js/",
			        sliderLayout:"fullwidth",
                    dottedOverlay:"none",
                    delay:9000,
                    navigation: {
                        keyboardNavigation:"off",
                        keyboard_direction: "horizontal",
                        mouseScrollNavigation:"off",
                            mouseScrollReverse:"default",
                        onHoverStop:"off",
                        touch:{
                            touchenabled:"on",
                            touchOnDesktop:"off",
                            swipe_threshold: 75,
                            swipe_min_touches: 1,
                            swipe_direction: "horizontal",
                            drag_block_vertical: false
                        },
                        arrows: {
                            style:"gyges",
                            enable:true,
                            hide_onmobile:true,
                            hide_under:600,
                            hide_onleave:false,
                            tmp:'',
                            left: {
                                h_align:"left",
                                v_align:"center",
                                h_offset:55,
                                v_offset:30
                            },
                            right: {
                                h_align:"right",
                                v_align:"center",
                                h_offset:55,
                                v_offset:30
                            }
                        }
                        
                    },
                     responsiveLevels:[1170,1040,778,480],
                     visibilityLevels:[1170,1040,778,480],
                     gridwidth:[1170,1040,778,480],
                     gridheight:[895,600,500,800],
                     lazyType:"none",
                     parallax: {
                         type:"scroll",
                         origo:"enterpoint",
                         speed:400,
                         levels:[5,10,15,20,25,30,35,40,45,50,46,47,48,49,50,55],
                         type:"scroll",
                     },
                     shadow:0,
                     spinner:"off",
                     stopLoop:"off",
                     stopAfterLoops:-1,
                     stopAtSlide:-1,
                     shuffle:"off",
                     autoHeight:"off",
                     hideThumbsOnMobile:"off",
                     hideSliderAtLimit:0,
                     hideCaptionAtLimit:0,
                     hideAllCaptionAtLilmit:0,
                     debugMode:false,
                     fallbacks: {
                         simplifyAll:"off",
                         nextSlideOnWindowFocus:"off",
                         disableFocusListener:false,
                     }
			    });
			});
		}
}
function mainBanner3() {
     if ($("#slider2").length > 0) {
        var e;
        $(document).ready(function() {
            e = jQuery("#slider2").revolution({
                               
                sliderType:"standard",
            jsFileLocation:"//mixtape.qodeinteractive.com/wp-content/plugins/revslider/public/assets/js/",
            sliderLayout:"fullscreen",
            dottedOverlay:"none",
            delay:4000,
            navigation: {
                keyboardNavigation:"off",
                keyboard_direction: "horizontal",
                mouseScrollNavigation:"off",
                            mouseScrollReverse:"default",
                onHoverStop:"off",
                arrows: {
                    style:"mixtape",
                    enable:true,
                    hide_onmobile:true,
                    hide_under:1025,
                    hide_onleave:false,
                    tmp:'',
                    left: {
                        h_align:"left",
                        v_align:"center",
                        h_offset:20,
                        v_offset:0
                    },
                    right: {
                        h_align:"right",
                        v_align:"center",
                        h_offset:20,
                        v_offset:0
                    }
                }
                ,
                bullets: {
                    enable:true,
                    hide_onmobile:false,
                    hide_over:1024,
                    style:"mixtape",
                    hide_onleave:false,
                    direction:"horizontal",
                    h_align:"center",
                    v_align:"bottom",
                    h_offset:0,
                    v_offset:20,
                    space:10,
                    tmp:''
                }
            },
            responsiveLevels:[1920,1600,778,480],
            visibilityLevels:[1920,1600,778,480],
            gridwidth:[1300,800,600,300],
            gridheight:[700,600,800,500],
            lazyType:"none",
            parallax: {
                type:"mouse",
                origo:"enterpoint",
                speed:400,
                speedbg:0,
                speedls:0,
                levels:[5,10,15,20,25,30,35,40,45,46,47,48,49,50,51,55],
            },
            shadow:0,
            spinner:"off",
            stopLoop:"off",
            stopAfterLoops:-1,
            stopAtSlide:-1,
            shuffle:"off",
            autoHeight:"off",
            fullScreenAutoWidth:"on",
            fullScreenAlignForce:"off",
            fullScreenOffsetContainer: ".touch .qodef-mobile-header",
            fullScreenOffset: "",
            disableProgressBar:"on",
            hideThumbsOnMobile:"off",
            hideSliderAtLimit:0,
            hideCaptionAtLimit:0,
            hideAllCaptionAtLilmit:0,
            startWithSlide:0,
            debugMode:false,
            fallbacks: {
                simplifyAll:"off",
                nextSlideOnWindowFocus:"off",
                disableFocusListener:false,
            }
                
                });
            });
        }
}

/*----------------- video -------------------*/
function VideoInit() {
    if ($(".home-section").length > 0) {
        $(window).on('scroll', function () {
                if($(window).scrollTop() >= 85 ){
                    $('.navbar-brand img').attr('src', 'http://rosettichefs.com/jelly/theOne/mansonv2/assets/img/demo/logos/logo-slider-black.png');
                }else{
                     if($(window).width()<769){
                         $('.navbar-brand img').attr('src', 'http://rosettichefs.com/jelly/theOne/mansonv2/assets/img/demo/logos/logo-slider-black.png');
                    }else{
                        $('.navbar-brand img').attr('src', 'http://rosettichefs.com/jelly/theOne/mansonv2/assets/img/demo/logos/logo-slider-white.png');
                    }
                }

             });
        if($(window).width()<769){
             $('.navbar-brand img').attr('src', 'http://rosettichefs.com/jelly/theOne/mansonv2/assets/img/demo/logos/logo-slider-black.png');
        }
        $(".home-section").css({
            "height": $(window).height() + "px"
        });
        $(".home-section .home-content").css({
            "margin-top": ($(window).height()/3) + "px"
        });
        
    }
}


/*----------------- portfolio change -------------------*/
function chgMas(cols){
$(".grid-portfolio .container-fluid").toggleClass('container-fluid container');

$("#gll").removeAttr('class');
    $("#gll").attr('class', 'grid-gallery');
    $("#gll").addClass('columns-'+cols);

$(".grid-gallery").isotope({
            itemSelector: ".grid-item",
            masonry: {
                columnWidth: ".grid-item",
            }
        });
}
function chgMas1(cols){

   $(".grid-portfolio .container").toggleClass('container container-fluid');
 
    $("#gll").removeAttr('class');
    $("#gll").attr('class', 'grid-gallery');
    $("#gll").addClass('columns-'+cols);


    $(".grid-gallery").isotope({
                itemSelector: ".grid-item",
                masonry: {
                    columnWidth: ".grid-item",
                }
            });
}

/*----------------- menu fullscreen -------------------*/

function menuFull() {
    $(".trigger-overlay").length > 0 && ($(".trigger-overlay").click(function() {
        return $(".overlay").hasClass("open") ? ($(".overlay").removeClass("open"), $(this).removeClass("is-active")) : ($(".overlay").addClass("open"), $(this).addClass("is-active")), !1
    }), $(".overlay").find("a").on("click", function(e) {
        $(".overlay").removeClass("open"), $(".dropdown-icon").removeClass("is-active")
    }))
}
$('img.svg').each(function(){
            var $img = jQuery(this);
            var imgID = $img.attr('id');
            var imgClass = $img.attr('class');
            var imgURL = $img.attr('src');

            $.get(imgURL, function(data) {
                // Get the SVG tag, ignore the rest
                var $svg = $(data).find('svg');

                // Add replaced image's ID to the new SVG
                if(typeof imgID !== 'undefined') {
                    $svg = $svg.attr('id', imgID);
                }
                // Add replaced image's classes to the new SVG
                if(typeof imgClass !== 'undefined') {
                    $svg = $svg.attr('class', imgClass+' replaced-svg');
                }

                // Remove any invalid XML tags as per http://validator.w3.org
                $svg = $svg.removeAttr('xmlns:a');

                // Replace image with new SVG
                $img.replaceWith($svg);

            }, 'xml');

        });


/*----------------- animations -------------------*/

function animationInview() {
    function e() {
        var e = i.height(),
            t = i.scrollTop(),
            o = t + e;
        $.each(a, function() {
            var e = $(this),
                a = e.outerHeight(),
                i = e.offset().top;
            i + a >= t && i <= o && e.addClass("in-view")
        })
    }
    var a = $(".js-inview"),
        i = $(window);
    i.on("scroll resize", e), i.trigger("scroll")
}

var clc=0;
$('.navbar-toggler').on('click',function ( e ){
    console.log(clc);
    e.preventDefault();
    if(clc==0){
        $('#navbarOppener').css('transform', 'translate3d(0, 0, 0)');
        clc=1;
    }else{
        $('#navbarOppener').css('transform', 'translate3d(0, -920px, 0)');
        clc=0;
    }
    
});
$('.icon-close').on('click',function ( e ){
    $('#navbarOppener').css('transform', 'translate3d(0,-920px, 0)');
        clc=0;
});
$('.navbarmob .navbar-nav .nav-link').on('click', function(){
    $('#navbarOppener').css('transform', 'translate3d(0,-920px, 0)');
});
$('.navbar li .dropdown-item').on('click', function(e){
  $('.navbar li .dropdown-menu').removeClass('show');
});
$('.nav-link').on('click', function(e){
  
    $('.nav-link').removeClass('active');
    $(this).addClass('active');
});
if($(window).width()>738 && $(window).width()<769){
   
    $('h3.about__title').find('br').remove();
}

if($(window).width()<1024){
$('.contentslide').flickity({
  "cellAlign": "left", 
  "wrapAround": true, 
  "pageDots": false
});
}

function lightboxgallery() {}! function(e) {
    e.fn.visible = function(a, i) {
        var t = e(this).eq(0),
            o = t.get(0),
            n = e(window),
            r = n.scrollTop();
        n = r + n.height();
        var l = t.offset().top,
            s = l + t.height();
        return t = !0 === a ? s : l, l = !0 === a ? l : s, !!(!0 !== i || o.offsetWidth * o.offsetHeight) && l <= n && t >= r
    }
}(jQuery), jQuery(window).load(function() {
        setTimeout(function() {
            jQuery("html,body").animate({
                scrollTop: jQuery(window).scrollTop() + 1
            }, 5, function() {
                jQuery("html,body").animate({
                    scrollTop: jQuery(window).scrollTop() - 1
                }, 5)
            })
        }, 2e3)
    }),
    function(e) {
        e.fn.extend({
            parallax: function(e) {
                return this.each(function() {
                    var e = jQuery(this);
                    setTimeout(function() {
                        var a = new Image;
                        a.onload = function() {
                            var a = this.height,
                                i = this.width;
                            e.data("imagewidth", i), e.data("imageheight", a)
                        }, a.src = e.data("parallax-image")
                    }, 500), jQuery(window).width() > 1024 ? (e.css({
                        background: "url(" + e.data("parallax-image") + ") center center"
                    }), setTimeout(function() {
                        moveParallax(e)
                    }, 500), jQuery(window).scroll(function() {
                        moveParallax(e)
                    })) : e.css({
                        background: "url(" + e.data("parallax-image") + ") center center",
                        "background-attachment": "inherit",
                        "background-size": "cover"
                    })
                })
            }
        })
    }(jQuery),
    function(e) {
        mainBanner(),mainBanner2(),mainBanner3(), VideoInit(), menuFull(), lightboxgallery();
        var a = e(".intro-default__slider").flickity({
            cellAlign: "center",
            wrapAround: !0,
            prevNextButtons: !1,
            pageDots: !1,
            draggable: !1
        });
        e(".default__slider-buttons").on("click", ".button", function() {
            var i = e(this).index();
            a.flickity("select", i), e(this).addClass("selected").siblings().removeClass("selected");
            var t = i + 1;
            e(".default__slider-counter").html("0" + t)
        }), e(window).on("load", function() {
            animationInview(), e("#mask").delay(500).fadeOut("slow", function() {
                animationInview()
            });
            var a = e(".grid-gallery").isotope({
                itemSelector: ".grid-item",
                masonry: {
                    columnWidth: ".grid-item"
                }
            });
            e(".js-filters").on("click", "li", function() {
                var i = e(this).attr("data-filter");
                a.isotope({
                    filter: i
                })
            }).each(function(a, i) {
                var t = e(i);
                t.on("click", "li", function() {
                    t.find(".is-checked").removeClass("is-checked"), e(this).addClass("is-checked")
                })
            }), e(".js-loadmore").on("click", function() {
                var i = e(".js-more-items").appendTo(a);
                return a.isotope("insert", i), e(this).hide(), !1
            }), jQuery().parallax && jQuery(".parallax-section").parallax(), e("a[href*=\\#]").on("click", function() {
                if (location.pathname.replace(/^\//, "") === this.pathname.replace(/^\//, "") && location.hostname === this.hostname) {
                    var a = e(this.hash);
                    if (a = a.length && a || e("[name=" + this.hash.slice(1) + "]"), a.length) {
                        var i = a.offset().top;
                        return e("html,body").animate({
                            scrollTop: i - 42
                        }, 1e3), !1
                    }
                }
            }), e("body.overflowed").length > 0 && e("#jHeader").addClass("overflow"), e(window).bind("scroll", function() {
                e("body.overflowed").length < 1 && (e(window).scrollTop() >= 85 ? e(".js-header").addClass("overflow") : e(".js-header").removeClass("overflow"), e(window).scrollTop() >= 2 ? e(".js-header-fixsmall").addClass("fixed-small") : e(".js-header-fixsmall").removeClass("fixed-small")), e(window).scrollTop() >= e(".jIntro").height() / 2 ? e(".js-header").addClass("fixed") : e(".js-header").removeClass("fixed")
            })
        })
    }(jQuery);

