$(window).on("load", function() {
    "use strict";

    //  ============= PRELOADER ===============

    $(".preloader").fadeOut();

    //  ============= MOBILE RESPONSIVE MENU ===============

    $(".menu-btn").on("click", function(){
      $(this).toggleClass("active");
      $(".responsive-mobile-menu").toggleClass("active");
    });

    $(".responsive-mobile-menu ul ul").parent().addClass("menu-item-has-children");
    $(".responsive-mobile-menu ul li.menu-item-has-children > a").on("click", function() {
      $(this).parent().toggleClass("active").siblings().removeClass("active");
      $(this).next("ul").slideToggle();
      $(this).parent().siblings().find("ul").slideUp();
      return false;
    });

    $("html, .menu-btn.active").on("click", function() {
      $(".responsive-mobile-menu").removeClass("active");
      $(".menu-btn").removeClass("active");
    });

    $(".menu-btn, .responsive-mobile-menu").on("click", function(e) {
      e.stopPropagation();
    });


    // STICKY HEADER 

    $(window).on("scroll", function () {
        if ($(this).scrollTop() > 1) {
            $("header").addClass("sticky animated slideInDown");
        } else {
            $("header").removeClass("sticky animated slideInDown");
        }
    });


    // handle links with @href started with '#' only
    $(document).on('click', 'a[href^="#"]', function(e) {
        // target element id
        var id = $(this).attr('href');

        // target element
        var $id = $(id);
        if ($id.length === 0) {
            return;
        }

        // prevent standard hash navigation (avoid blinking in IE)
        e.preventDefault();

        // top position relative to the document
        var pos = $id.offset().top;

        // animated top scrolling
        $('body, html').animate({scrollTop: pos});
    });




});


