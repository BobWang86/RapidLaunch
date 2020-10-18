/*---LEFT BAR ACCORDION----*/
$(function() {
    $('#nav-accordion').dcAccordion({
    eventType: 'click',
    autoClose: true,
    saveState: true,
    disableLink: true,
    speed: 'slow',
    showCount: false,
    autoExpand: true,
    cookie: 'dcjq-accordion-1',
    classExpand: 'dcjq-current-parent'
    });

    //    tool tips
    $('.tooltips').tooltip();

    //    popovers
    $('.popovers').popover();

    //    sidebar dropdown menu auto scrolling
    jQuery('#sidebar .sub-menu > a').click(function () {
        var o = ($(this).offset());
        diff = 250 - o.top;
        if (diff > 0)
            $("#sidebar").scrollTo("-=" + Math.abs(diff), 500);
        else
            $("#sidebar").scrollTo("+=" + Math.abs(diff), 500);
    });

    //  sidebar toggle
    $(function () {
        function responsiveView() {
            var wSize = $(window).width();
            if (wSize <= 768) {
                $('#container').addClass('sidebar-close');
                $('#sidebar > ul').hide();
            }

            if (wSize > 768) {
                $('#container').removeClass('sidebar-close');
                $('#sidebar > ul').show();
            }
        }
        $(window).on('load', responsiveView);
        $(window).on('resize', responsiveView);
    });

    $('.fa-bars').click(function () {
        if ($('#sidebar > ul').is(":visible") === true) {
            $('#main-content').animate({
                'margin-left': '0px'
            }, 350, function () {
                $("#container").addClass("sidebar-closed");
            });

            $('#sidebar').animate({
                'margin-left': '-210px'
            }, 350, function () {
                $('#sidebar > ul').hide();
            });
        } else {
            $('#sidebar > ul').show();

            $('#main-content').animate({
                'margin-left': '210px'
            }, 350, function () {
                $("#container").removeClass("sidebar-closed");
            });

            $('#sidebar').animate({
                'margin-left': '0px'
            }, 350, function () {
                
            });   
        }
    });

    // custom scrollbar
    $("#sidebar").niceScroll({
        styler: "fb",
        cursorcolor: "#4ECDC4",
        cursorwidth: '3',
        cursorborderradius: '10px',
        background: '#404040',
        spacebarenabled: false,
        cursorborder: ''
    });

    // widget tools
    jQuery('.panel .tools .fa-chevron-down').click(function () {
        var el = jQuery(this).parents(".panel").children(".panel-body");
        if (jQuery(this).hasClass("fa-chevron-down")) {
            jQuery(this).removeClass("fa-chevron-down").addClass("fa-chevron-up");
            el.slideUp(200);
        } else {
            jQuery(this).removeClass("fa-chevron-up").addClass("fa-chevron-down");
            el.slideDown(200);
        }
    });

    jQuery('.panel .tools .fa-times').click(function () {
        jQuery(this).parents(".panel").parent().remove();
    });

    // custom bar chart
    if ($(".custom-bar-chart")) {
        $(".bar").each(function () {
            var i = $(this).find(".value").html();
            $(this).find(".value").html("");
            $(this).find(".value").animate({
                height: i
            }, 2000)
        })
    }

    // Go to top
    $('.go-top').on('click', function (e) {
        e.preventDefault();
        $('html, body').animate({ scrollTop: 0 }, 500);
    });
});