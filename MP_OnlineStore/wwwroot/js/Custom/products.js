$(document).ready(function () {
    const categorySelect = $('*[id*=category-name]');
    const productInputs = $('*[id*=product-name]');

    categorySelect.each(function () { $(this).on("change", function (vent) { UpdateCategory(vent); }) });
    productInputs.each(function() { $(this).on("change", function(vent) { UpdateProductName(vent); }) });
});

function UpdateCategory(vent) {
    const target = $(vent.currentTarget);
    const categoryId = target.find(":selected").data('key');
    const id = target.data('key');
    const productName = $('[id="product-name"][data-key="' + id + '"]').val();
    const quantityPerUnit = $('[id="quantity-per-unit"][data-key="' + id + '"]').val();
    const unitPrice = $('[id="unit-price"][data-key="' + id + '"]').val();

    const model = {/* CategoryId: categoryId, ProductId: id, ProductName: productName, QuantityPerUnit: quantityPerUnit, */UnitPrice: unitPrice}
    $.ajax({
        url: "/api/products/edit",
        type: "POST",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ UnitPrice: unitPrice}),
        success: function (data) {
            alert("ok");
        }
    });
    console.log("CategoryId: " + categoryId +
        "\nProductId: " + id +
        "\nProductName: " + productName +
        "\nQuantityPerUnit: " + quantityPerUnit + 
        "\nUnitPrice: " + unitPrice);
}

function UpdateProductName(vent) {
    const target = $(vent.currentTarget);
    const productName = target.val();
    const id = target.data('key');

    const model = { ProductId: id, ProductName: productName }
    $.ajax({
        url: "/api/products/edit",
        type: "POST",
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(model),
        success: function (data) {
            alert("ok");
        }
    });
    console.log("ProductName: " + productName + "\nProductId: " + id);
}
