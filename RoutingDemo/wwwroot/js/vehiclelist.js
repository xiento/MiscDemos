$(document).ready(function () {

    var haveLoadedMore = $('body').data('have-loaded-more') === 'True';

    if (haveLoadedMore) {
        //scroll to bottom of page
        $("html").animate({
            scrollTop: $(document).height()
        }, "slow", function () {
                //animate the last 10 rows of table to show the newly added rows
                $('table > tbody > tr').slice(-10).toggleClass('table-success', 1000);
        });
    }

});