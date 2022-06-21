//$(document).ready(function() {
//    $("a[rel^='prettyPhoto']").prettyPhoto();
//}); 



$(".redirect-dropdown").change(function (event) {
    var url = $(event.target).find(':selected').attr("data-href");
    if (url.length > 0)
        window.location.href = url;
});

function addToCart(event) {
    var btn = event.target;
    var nodeId = btn.dataset.nodeid;

    var qntyInput = $(btn).prev(".quantity-input");
    var quantity = 1;
    if (qntyInput.length > 0) {
        quantity = qntyInput.val();
    }

    var url = "/Partials/Shop/AddToCart"; // the script where you handle the form input.
    var data = { nodeId: nodeId, quantity: quantity };
    $.ajax({
        type: "POST",
        url: url,
        data: data,
        success: function (cartResult) {
            console.log("success");
            $(".cart-wrapper").html(cartResult);
        }
    });

}

$(document).ready(function () {
    $('.btn-add-to-cart').click(function (e) {
        addToCart(e);
    });
    $('.btn-clear-cart').click(function (e) {
        e.preventDefault();
        var url = "/Partials/Shop/ClearCart"; // the script where you handle the form input.
        $.ajax({
            type: "POST",
            url: url,
            success: function (result) {
                location.reload();
            }
        });
    });
});