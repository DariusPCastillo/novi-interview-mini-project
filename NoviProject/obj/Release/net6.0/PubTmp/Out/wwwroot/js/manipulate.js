$(document).ready(function () {

    $("body > div > main > div > table > tbody > tr > td:nth-child(5)").each(function (x) {
        var td = $(this).text().replace("non_member", "Guest").replace("expired", "Expired");
        $(this).text(td);
    });

}); 


