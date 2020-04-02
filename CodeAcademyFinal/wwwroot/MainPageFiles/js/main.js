$(document).ready(function () {
    "use strict"; $(window).scroll(function () {
        if ($(window).outerWidth() >= 1200) {
            if ($(window).scrollTop() > 200) { $("header").css({ "position": "fixed" }); $("header .custom-container-fluid").css({ "background-color": "rgb(22, 29, 33)" }) }
            else { $("header").css({ "position": "absolute" }); $("header .custom-container-fluid").css({ "background-color": "transparent" }) }
        }
        else {
            if ($(window).scrollTop() > 200) { $("header").css({ "position": "fixed" }); $("header .container-fluid").css({ "background-color": "rgb(22, 29, 33)" }); $("header .toggle-bars").css({ "color": "rgb(196, 228, 13)" }) }
            else { $("header").css({ "position": "absolute" }); $("header .container-fluid").css({ "background-color": "transparent" }); $("header .toggle-bars").css({ "color": "rgb(196, 228, 13)" }) }
        }
    })
    $(".resp-nav-links").hide(); $(".toggle-bars").click(function () { $(".resp-nav-links").show().animate({ left: "0%" }, 500); $("body").css({ "overflow-y": "hidden" }) })
    $(".btn-close").click(function () { $(".resp-nav-links").animate({ left: "100%" }).hide(500); $("body").css({ "overflow-y": "scroll" }) })
    $(document).on("change", ".search-property", function () {
        var propertyName = this.options[this.selectedIndex].text; if (propertyName == "Mənzil" || propertyName == "Ev/Villa") { $(".search-rooms").css({ "display": "block" }); $(".search-square").css({ "display": "none" }) }
        else { $(".search-rooms").css({ "display": "none" }); $(".search-square").css({ "display": "block" }) }
    })
    $(document).on("click", "#vip-recent-announcements .vra-col .favourite-heart-empty", function () { $(this).css({ "display": "none" }); $(this).next().css({ "display": "block" }) })
    $(document).on("click", "#vip-recent-announcements .vra-col .favourite-heart-filled", function () { $(this).css({ "display": "none" }); $(this).prev().css({ "display": "block" }) })
    $(window).scroll(function () {
        if ($(window).scrollTop() > 200) { $("#btn-up-scroll-container").css({ "visibility": "visible", "opacity": 1 }) }
        else { $("#btn-up-scroll-container").css({ "visibility": "hidden", "opacity": 0 }) }
    })
    $("#btn-up-scroll-container").click(function () { $("html").animate({ scrollTop: 0 }, 500) })
    $(document).on("click", ".input-upload-mask", function () { $(".input-upload").click() })
    $(document).on("click", ".fa-upload", function () { $(".input-upload").click() })
    $(document).on("change", ".input-upload", function (e) {
        [...e.target.files].forEach(file => {
            if (file.type.match("image/*")) {
                var fileReader = new FileReader(); fileReader.onloadend = function (event) { $(".register-message").html([...e.target.files].length + " şəkil seçilib") }
                fileReader.readAsDataURL(file)
            }
        })
    })
    setTimeout(function () { $("#confirmation .success-icon").css({ "animation-name": "SuccessIconRotation" }) }, 300); var propertyName = $(".create-announcement-property").val(); if (propertyName == 1 || propertyName == 2) { $(".create-announcement-rooms").css({ "display": "block" }); $(".create-announcement-square-container").css({ "display": "none" }); $(".create-announcement-square-container-for-specials").parent().parent().css({ "display": "block" }); $(".create-announcement-input-upload").parent().parent().attr("class", "col-xs-12") }
    else { $(".create-announcement-rooms").css({ "display": "none" }); $(".create-announcement-square-container").css({ "display": "block" }); $(".create-announcement-square-container-for-specials").parent().parent().css({ "display": "none" }); $(".create-announcement-input-upload").parent().parent().attr("class", "col-xs-12 col-sm-6") }
    $(document).on("change", ".create-announcement-property", function () {
        var propertyName = this.options[this.selectedIndex].text; if (propertyName == "Mənzil" || propertyName == "Ev/Villa") { $(".create-announcement-rooms").css({ "display": "block" }); $(".create-announcement-square-container").css({ "display": "none" }); $(".create-announcement-square-container-for-specials").parent().parent().css({ "display": "block" }); $(".create-announcement-input-upload").parent().parent().attr("class", "col-xs-12") }
        else { $(".create-announcement-rooms").css({ "display": "none" }); $(".create-announcement-square-container").css({ "display": "block" }); $(".create-announcement-square-container-for-specials").parent().parent().css({ "display": "none" }); $(".create-announcement-input-upload").parent().parent().attr("class", "col-xs-12 col-sm-6") }
    })
    $(".checkbox-for-submit-disabled").removeClass("checked"); $(".checkbox-for-submit-disabled").removeAttr("checked"); $(".submit-for-checkbox-checked").attr("style", "opacity:0.5"); $(".submit-for-checkbox-checked").attr("disabled", !0); $(document).on("click", ".checkbox-for-submit-disabled", function () {
        if ($(".checkbox-for-submit-disabled").hasClass("checked")) { $(this).removeClass("checked"); $(".submit-for-checkbox-checked").attr("style", "opacity:0.5"); $(".submit-for-checkbox-checked").attr("disabled", !0); $(".submit-for-checkbox-checked").addClass("disabled") }
        else { $(this).addClass("checked"); $(".submit-for-checkbox-checked").removeAttr("style"); $(".submit-for-checkbox-checked").attr("disabled", !1); $(".submit-for-checkbox-checked").removeClass("disabled") }
    })
    if ($("#announcement .validation-error-for-update").val() == "1") { $("#announcement .announcement-edit-container-col").siblings().css({ "display": "none" }); $("#announcement .announcement-edit-container").css({ "visibility": "visible", "opacity": 1, "display": "flex" }); $("#announcement .announcement-right-side").css({ "visibility": "hidden", "opacity": 0, "display": "none" }); $("#announcement .announcement-left-side").attr("class", "col-xs-12 announcement-left-side") }
    $(document).on("click", "#announcement .announcement-details-edit", function () { $("#announcement .announcement-edit-container-col").siblings().css({ "display": "none" }); $("#announcement .announcement-edit-container").css({ "visibility": "visible", "opacity": 1, "display": "flex" }); $("#announcement .announcement-right-side").css({ "visibility": "hidden", "opacity": 0, "display": "none" }); $("#announcement .announcement-left-side").attr("class", "col-xs-12 announcement-left-side") })
    $("#announcement .announcement-delete-container-col").hide(); $(document).on("click", "#announcement .announcement-details-delete", function () { $("#announcement .announcement-delete-container-col").fadeIn(); $("#announcement .announcement-blur").css({ "filter": "blur(1px)" }) })
    $(document).on("click", "#announcement .announcement-delete-no", function () { $("#announcement .announcement-delete-container-col").fadeOut(); $("#announcement .announcement-blur").css({ "filter": "blur(0px)" }) })
    function DefineBigPhotoLentWidth() { var liBigTotalWidth = $("#announcement .announcement-slider-photos li").length * 100; $("#announcement .announcement-slider-photos").css({ "width": liBigTotalWidth + "%" }) }
    DefineBigPhotoLentWidth(); var indexLiBig = 0; function BigPhotoSlideRight() {
        indexLiBig++; var liBigWidth = $("#announcement .announcement-slider-photos li").width(); $("#announcement .announcement-slider-photos").css({ left: -indexLiBig * liBigWidth + "px" })
        if (indexLiBig === $("#announcement .announcement-slider-photos li").length) { indexLiBig = 0; $("#announcement .announcement-slider-photos").css({ left: -indexLiBig * liBigWidth + "px" }) }
        $("#announcement .announcement-slider-photos li.slider-big-active").removeClass("slider-big-active"); $("#announcement .announcement-slider-photos li").eq(indexLiBig).addClass("slider-big-active"); $("#announcement .announcement-slider-thumbnail li.slider-active").removeClass("slider-active"); $("#announcement .announcement-slider-thumbnail li").eq(indexLiBig).addClass("slider-active")
    }
    function BigPhotoSlideLeft() {
        indexLiBig--; var liBigWidth = $("#announcement .announcement-slider-photos li").width(); $("#announcement .announcement-slider-photos").css({ left: -indexLiBig * liBigWidth + "px" })
        if (indexLiBig < 0) { indexLiBig = $("#announcement .announcement-slider-photos li").length - 1; $("#announcement .announcement-slider-photos").css({ left: -indexLiBig * liBigWidth + "px" }) }
        $("#announcement .announcement-slider-photos li.slider-big-active").removeClass("slider-big-active"); $("#announcement .announcement-slider-photos li").eq(indexLiBig).addClass("slider-big-active"); $("#announcement .announcement-slider-thumbnail li.slider-active").removeClass("slider-active"); $("#announcement .announcement-slider-thumbnail li").eq(indexLiBig).addClass("slider-active")
    }
    $(document).on("click", "#announcement .big-right-arrow", function () { BigPhotoSlideRight() }); $(document).on("click", "#announcement .big-left-arrow", function () { BigPhotoSlideLeft(); console.log(indexLiBig) }); $(window).resize(function () { DefineBigPhotoLentWidth(); BigPhotoSlideRight(); BigPhotoSlideLeft() })
    function DefineSmallPhotoLentWidth() { var liSmallTotalWidth = $("#announcement .announcement-slider-thumbnail li").length * 25; $("#announcement .announcement-slider-thumbnail").css({ "width": liSmallTotalWidth + "%" }) }
    DefineSmallPhotoLentWidth(); var indexLiSmall = 0; function SmallPhotoSlideRight() {
        indexLiSmall++; var liSmallWidth = $("#announcement .announcement-slider-thumbnail li").width(); $("#announcement .announcement-slider-thumbnail").css({ left: -indexLiSmall * liSmallWidth + "px" })
        if (indexLiSmall === $("#announcement .announcement-slider-thumbnail li").length) { indexLiSmall = 0; $("#announcement .announcement-slider-thumbnail").css({ left: -indexLiSmall * liSmallWidth + "px" }) }
    }
    function SmallPhotoSlideLeft() {
        indexLiSmall--; var liSmallWidth = $("#announcement .announcement-slider-thumbnail li").width(); $("#announcement .announcement-slider-thumbnail").css({ left: -indexLiSmall * liSmallWidth + "px" })
        if (indexLiSmall < 0) { indexLiSmall = $("#announcement .announcement-slider-thumbnail li").length - 1; $("#announcement .announcement-slider-thumbnail").css({ left: -indexLiSmall * liSmallWidth + "px" }) }
    }
    $(document).on("click", "#announcement .small-right-arrow", function () { SmallPhotoSlideRight() }); $(document).on("click", "#announcement .small-left-arrow", function () { SmallPhotoSlideLeft() }); $(window).resize(function () { DefineSmallPhotoLentWidth(); SmallPhotoSlideRight(); SmallPhotoSlideLeft() })
    $(document).on("click", "#announcement .announcement-slider-thumbnail li", function () { $("#announcement .announcement-slider-thumbnail li.slider-active").removeClass("slider-active"); $(this).addClass("slider-active"); var index = $(this).index(); indexLiBig = index - 1; BigPhotoSlideRight() })
    $("#my-profile .my-profile-tab").click(function () { $("#my-profile .my-profile-details-loader-container").css({ "display": "block", "visibility": "visible", "opacity": 1 }); $("#my-profile .my-profile-tab.tab-active").removeClass("tab-active"); $(this).addClass("tab-active"); var tabId = $(this).attr("data-id"); $("#my-profile .my-profile-details.details-active").removeClass("details-active"); var detailsFittingToTab = $(`#my-profile .my-profile-details[data-id="${tabId}"]`); detailsFittingToTab.addClass("details-active"); $("#my-profile .my-profile-details-loader-container").css({ "display": "block", "visibility": "hidden", "opacity": 0 }) })
    function GetCookie() { var cookieValue = $(".cookie-favourites-for-user-announcements").val(); if (cookieValue != null) { var cookieArray = cookieValue.split("+"); for (var i = 0; i < cookieArray.length; i++) { var cookieArrayValue = cookieArray[i]; var selectedItem = $(`.fa-heart[data-info="${cookieArrayValue}"]`); selectedItem.css({ "display": "none" }); selectedItem.next().css({ "display": "block" }) } } }
    GetCookie(); $(document).on("submit", "#search-area .search-area-form", function (e) {
        e.preventDefault(); $("#vip-recent-announcements .container-fluid .custom-container-fluid .vip-row-for-load-more").empty(); $("#vip-recent-announcements .container-fluid .custom-container-fluid .vip-for-load-more").remove(); $("#vip-recent-announcements .container-fluid .custom-container-fluid .recent-heading-container").remove(); $("#vip-recent-announcements .container-fluid .custom-container-fluid .recent-row-for-load-more").remove(); $("#vip-recent-announcements .container-fluid .custom-container-fluid .recent-for-load-more").remove(); $("#vip-recent-announcements .container-fluid .custom-container-fluid .most-heading-container").remove(); $("#vip-recent-announcements .container-fluid .custom-container-fluid .most-row-for-load-more").remove(); $("#vip-recent-announcements .container-fluid .custom-container-fluid .most-for-load-more").remove(); setTimeout(function () { $(window).scrollTop(550) }, 500); var duration = $("#search-area .search-time").val(); var estate = $("#search-area .search-property").val(); var room = $("#search-area .search-rooms").val(); var area = $("#search-area .search-square").val().trim(); var price = $("#search-area .search-price").val(); var city = $("#search-area .search-location").val(); $("#search-area .duration-for-more-search-results").val(`${duration}`); $("#search-area .estate-for-more-search-results").val(`${estate}`); $("#search-area .room-for-more-search-results").val(`${room}`); $("#search-area .area-for-more-search-results").val(`${area}`); $("#search-area .price-for-more-search-results").val(`${price}`); $("#search-area .city-for-more-search-results").val(`${city}`); $.ajax({
            url: "/AJAX/GetSearchResult?duration=" + duration + "&estate=" + estate + "&room=" + room + "&area=" + area + "&price=" + price + "&city=" + city, type: "GET", success: function (response) {
                $("#vip-recent-announcements .container-fluid .custom-container-fluid .vip-heading-container h3").text("Axtarışın nəticəsi"); $("#vip-recent-announcements .container-fluid .custom-container-fluid .vip-row-for-load-more").append(response); $("#vip-recent-announcements .container-fluid .custom-container-fluid .search-result-for-load-more").css({ "display": "flex" }); if (response == 0) { $("#vip-recent-announcements .container-fluid .custom-container-fluid .vip-row-for-load-more").append('<div style="display:flex;justify-content:center;width:100%;"><h3 style="font-size:30px;font-family:&quot;Maven Pro Light 300&quot;;"> Axtardığınız əmlak tapılmadı</h3 ></div>'); $("#vip-recent-announcements .container-fluid .custom-container-fluid .search-result-for-load-more").css({ "display": "none" }) }
                GetCookie()
            }, error: function (request, status, error) {
                if (request.statusCode != 200) { $("#vip-recent-announcements .container-fluid .custom-container-fluid .vip-heading-container h3").text("Axtarışın nəticəsi"); $("#vip-recent-announcements .container-fluid .custom-container-fluid .vip-row-for-load-more").append('<div style="display:flex;justify-content:center;width:100%;"><h3 style="font-size:30px;font-family:&quot;Maven Pro Light 300&quot;;"> Axtardığınız əmlak tapılmadı</h3 ></div>'); $("#vip-recent-announcements .container-fluid .custom-container-fluid .search-result-for-load-more").css({ "display": "none" }) }
            }
        })
    })
    $(document).on("click", "#vip-recent-announcements .search-result-for-load-more .load-more", (function () {
        var skipCount = parseInt($(".skip-count-for-search-result-announcements").val()); var duration = $("#search-area .duration-for-more-search-results").val(); var estate = $("#search-area .estate-for-more-search-results").val(); var room = $("#search-area .room-for-more-search-results").val(); var area = $("#search-area .area-for-more-search-results").val().trim(); var price = $("#search-area .price-for-more-search-results").val(); var city = $("#search-area .city-for-more-search-results").val(); $.ajax({
            url: "/AJAX/GetMoreSearchResults?skipCount=" + skipCount + "&duration=" + duration + "&estate=" + estate + "&room=" + room + "&area=" + area + "&price=" + price + "&city=" + city, type: "GET", success: function (response) {
                $("#vip-recent-announcements .vip-row-for-load-more").append(response); skipCount += 6; $(".skip-count-for-search-result-announcements").val(`${skipCount}`); var count = parseInt($(".count-for-search-result-announcements").val()); if (skipCount >= count) { $("#vip-recent-announcements .search-result-for-load-more .load-more").css({ "display": "none" }) }
                GetCookie()
            }
        })
    })); $(document).on("click", ".favourite-heart-empty", function () { $(this).css({ "display": "none" }); $(this).next().css({ "display": "block" }); var dataInfo = $(this).attr("data-info"); $.ajax({ url: "/AJAX/AddRemoveAnnouncementsToFromFavourites?dataInfo=" + dataInfo, type: "GET", success: function (response) { } }) }); $(document).on("click", ".favourite-heart-filled", function () { $(this).css({ "display": "none" }); $(this).prev().css({ "display": "block" }); var dataInfo = $(this).attr("data-info"); $.ajax({ url: "/AJAX/AddRemoveAnnouncementsToFromFavourites?dataInfo=" + dataInfo, type: "GET", success: function (response) { } }) }); $(document).on("click", "#user-announcements .load-more", (function () {
        var userId = $(".the-user-id-for-user-announcements").val(); var skipCount = parseInt($(".skip-count-for-user-announcements").val()); $.ajax({
            url: "/AJAX/GetUserAnnouncements?userId=" + userId + "&skipCount=" + skipCount, type: "GET", success: function (response) {
                $("#user-announcements .vip-heading-container").next().append(response); skipCount += 6; $(".skip-count-for-user-announcements").val(`${skipCount}`); var count = parseInt($(".count-for-user-announcements").val()); if (skipCount >= count) { $("#user-announcements .load-more").css({ "display": "none" }) }
                GetCookie()
            }
        })
    })); $(document).on("click", "#vip-recent-announcements .alike-announcements-for-load-more .load-more", (function () {
        var skipCount = parseInt($(".skip-count-for-alike-announcements").val()); var estateId = parseInt($(".estate-id-for-alike-announcements").val()); $.ajax({
            url: "/AJAX/GetAlikeAnnouncements?skipCount=" + skipCount + "&estateId=" + estateId, type: "GET", success: function (response) {
                $("#vip-recent-announcements .alike-row-for-load-more").append(response); skipCount += 6; $(".skip-count-for-alike-announcements").val(`${skipCount}`); var count = parseInt($(".count-for-alike-announcements").val()); if (skipCount >= count) { $("#vip-recent-announcements .alike-announcements-for-load-more .load-more").css({ "display": "none" }) }
                GetCookie()
            }
        })
    })); $(document).on("click", "#vip-recent-announcements .vip-for-load-more .load-more", (function () {
        var skipCount = parseInt($(".skip-count-for-vip-announcements").val()); $.ajax({
            url: "/AJAX/GetVipAnnouncements?skipCount=" + skipCount, type: "GET", success: function (response) {
                $("#vip-recent-announcements .vip-row-for-load-more").append(response); skipCount += 6; $(".skip-count-for-vip-announcements").val(`${skipCount}`); var count = parseInt($(".count-for-vip-announcements").val()); if (skipCount >= count) { $("#vip-recent-announcements .vip-for-load-more .load-more").css({ "display": "none" }) }
                GetCookie()
            }
        })
    })); $(document).on("click", "#vip-recent-announcements .recent-for-load-more .load-more", (function () {
        var skipCount = parseInt($(".skip-count-for-recent-announcements").val()); $.ajax({
            url: "/AJAX/GetRecentAnnouncements?skipCount=" + skipCount, type: "GET", success: function (response) {
                $("#vip-recent-announcements .recent-row-for-load-more").append(response); skipCount += 6; $(".skip-count-for-recent-announcements").val(`${skipCount}`); var count = parseInt($(".count-for-recent-announcements").val()); if (skipCount >= count) { $("#vip-recent-announcements .recent-for-load-more .load-more").css({ "display": "none" }) }
                GetCookie()
            }
        })
    })); $(document).on("click", "#vip-recent-announcements .most-for-load-more .load-more", (function () {
        var skipCount = parseInt($(".skip-count-for-most-announcements").val()); $.ajax({
            url: "/AJAX/GetMostViewedAnnouncements?skipCount=" + skipCount, type: "GET", success: function (response) {
                $("#vip-recent-announcements .most-row-for-load-more").append(response); skipCount += 6; $(".skip-count-for-most-announcements").val(`${skipCount}`); var count = parseInt($(".count-for-most-announcements").val()); if (skipCount >= count) { $("#vip-recent-announcements .most-for-load-more .load-more").css({ "display": "none" }) }
                GetCookie()
            }
        })
    })); $(".loader-container").addClass("hidden")
})