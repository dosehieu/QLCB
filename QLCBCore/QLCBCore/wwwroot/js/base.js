$('#btn_add').click(function () {
    var link = $(this).attr("data-link");
    window.location.href = link;
});
$('#btn_delete').click(function () {
    var type = $(this).attr("data-type");
    var title = $(this).attr("data-title");
    var name = $(this).attr("data-name");
    var id = $(this).attr("data-id");
    var link_delete = $(this).attr("data-link");
    $('#myModal').modal();
    $('.modal-title').html("Xóa " + title);
    $('.modal-body').html("Bạn có chắc chắn muốn xóa " + title + " : " + name);
    $('#btn_ok').html("Đồng ý");
    $('#btn_ok').attr("data-link", link_delete);
    $('#btn_ok').attr("data-id", id);
    $('#btn_ok').attr("data-type", type);

});
$('#btn_ok').click(function () {
    debugger
    var type = $(this).attr("data-type");
    //type =1 : Xóa
    if (type == "delete") {

        var id = $(this).attr("data-id");
        var link_delete = $(this).attr("data-link");
        $.ajax({
            type: "GET",
            url: link_delete + "/" + id,
            dataType: "text",
            success: function (data) {
                const Toast = Swal.mixin({
                    toast: true,
                    position: 'top-end',
                    showConfirmButton: false,
                    timer: 3000
                });
                Toast.fire({
                    type: 'success',
                    title: 'Xóa bản ghi thành công',
                })
            },
            error: function (result) {
                const Toast = Swal.mixin({
                    toast: true,
                    position: 'top-end',
                    showConfirmButton: false,
                    timer: 3000
                });
                Toast.fire({
                    type: 'error',
                    title: 'Xóa bản ghi thất bại: ' + result,
                })
            }
        });
        $('#myModal').modal('toggle');
        setTimeout(function () {
            window.location.reload();
        }, 2000)

    }
});
