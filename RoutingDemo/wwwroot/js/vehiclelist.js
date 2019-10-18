$(document).ready(function () {
    $('button.btn-info').click(function (e) {
        e.preventDefault();

        var numberOfRows = $('table > tbody > tr').length;
        var postData = { skip: numberOfRows };

        $.post('/', postData).done(function (vehicles) {
            $.each(vehicles, function (i, vehicle) {
                var tableRowHtml = ['<tr><td><strong>', vehicle.id, '</strong></td><td>', vehicle.make, '</td><td>', vehicle.model, '</td><td>', vehicle.licenseNumber, '</td></tr>'].join('');
                $('table > tbody').append(tableRowHtml);
            });

            if (vehicles.length < 10) {
                //This means we reached the final page and there's no more vehicles to load, hide the button
                $('button.btn-info').hide();
            }

            //scroll to bottom of page
            $("html").animate({
                scrollTop: $(document).height()
            }, "slow", function () {
                $('table > tbody > tr').removeClass('table-success');
                //animate the last 10 rows of table to show the newly added rows
                $('table > tbody > tr').slice(-10).toggleClass('table-success', 1000);
            });

        }).fail(function (error) {
            console.log(error);
        });
    });
});