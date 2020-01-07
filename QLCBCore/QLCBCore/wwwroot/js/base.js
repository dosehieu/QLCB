$(document).ready(function () {
    base_formAction();
    base_pagination();
    base_datatable();
    base_lentop();
    bsCustomFileInput.init();
    base_menuActive();
});

function base_formAction() {
    $('.btn_link').click(function () {
        var link = $(this).attr("data-link");
        window.location.href = link;
    });
    $('.btn_delete').click(function () {
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
        var type = $(this).attr("data-type");
        //type =1 : Xóa
        if (type == "delete") {
            debugger
            var id = $(this).attr("data-id");
            var link_delete = $(this).attr("data-link");
            $.ajax({
                type: "GET",
                url: link_delete + "/" + id,
                dataType: "text",
                success: function (data) {
                    flag = 1;
                    const Toast = Swal.mixin({
                        toast: true,
                        position: 'top-end',
                        showConfirmButton: false,
                        timer: 3000
                    });
                    Toast.fire({
                        type: 'success',
                        title: 'Xóa bản ghi thành công',
                    });
                    $('#myModal').modal('toggle');
                    setTimeout(function () {
                        window.location.reload();
                    }, 2000)
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
                        title: 'Xóa thất bại do đơn vị đang được sử dụng ! ',
                    });
                    $('#myModal').modal('toggle');
                    
                }
            });
            
            
            
            
        }
    });
}

function base_pagination() {
    $('#CB_RowPerPage').change(function () {
        debugger
        var link = $(this).attr('data-link');
        link += "&RowPerPage=" + $(this).val();
        window.location.href = link;
    });
    $('#IP_Page').change('click', function (e) {
        var title = "";
        var rowperpage = $('#Help_RowPerPage').attr('data-RowPerPage');
        var cPage = $(this).val();
        var maxPage = $('#Help_TotalPage').val();
        if (cPage.length == 0)
            title = "Yêu cầu nhập trang cần chuyển đến";
        else if (isNaN(cPage)) {
            cPage = 1;
            title = "Trang chuyển đến phải là kiểu số";

        } else if (parseInt(cPage) > maxPage) {
            cPage = 1;
            title = "Trang không được lớn hơn " + maxPage + "";
        } else if (parseInt(cPage) <= 0) {
            {
                cPage = 1;
                title = "Trang phải lớn hơn 0";
            }
        } else if (cPage.indexOf(".") > 0) //|| cPage.contains(".") => ham contains => chrome không hiểu
        {
            cPage = 1;
            title = "Trang chuyển đến phải là kiểu số nguyên dương";
        } else {
            var link = $(this).attr('data-link');
            var RowPerPage = $('#Help_RowPerPage').attr('data-RowPerPage');
            link += $(this).val() + "&RowPerPage=" + RowPerPage;
            window.location.href = link;
            return false;
        }
        const Toast = Swal.mixin({
            toast: true,
            position: 'top-end',
            showConfirmButton: false,
            timer: 3000
        });
        Toast.fire({
            type: 'error',
            title: title,
        });
    });
}

function base_datatable() {
    $('.table-jquery thead tr').clone(true).appendTo('.table-jquery thead');
    $('.table-jquery thead tr:eq(1) th').each(function (i) {
        var title = $(this).text();
        if (title != "") {
            $(this).html('<input class="form-control" type="text" />');
            $('input', this).on('keyup change', function () {
                if (table.column(i).search() !== this.value) {
                    table
                        .column(i)
                        .search(this.value)
                        .draw();
                }
            });
        }
    });
    var table = $('.table-jquery').DataTable({
        orderCellsTop: true,
        language: {
            url: "/Layout/plugins/dataTables/Vietnamese.json"
        }
    });
}

function base_lentop() {
    
    $(window).scroll(function () {
        if ($(this).scrollTop() > 200) $(".gotop").fadeIn();
        else $(".gotop").fadeOut();
    });
    $(".gotop").click(function () {
        $("body,html").animate({ scrollTop: 0 }, "slow");
    });
    
}

function base_menuActive() {
    var pathname = window.location.pathname;
    var div = pathname.split('/', 2);
    var re = div[1];
    $("[data-active=" + re + "]").addClass("active");
    var parent = $("[data-active=" + re + "]").attr('data-parent');
    $("[data-active=" + re + "]").closest("ul").css("display", "block");
    $("[data-active=" + parent + "]").addClass("active");
    $("[data-active=" + parent + "]").closest("li").addClass("menu-open");
}

function base_navLink(title) {
    $('.breadcrumb-item.active').html(title);
    $('.m-0.text-dark').html(title);
}

function base_navLink2(title, title2, link) {
    $('.breadcrumb-item.active').html(title);
    $('.m-0.text-dark').html(title);
    $('.breadcrumb-item.display-none > a').html(title2);
    $('.breadcrumb-item.display-none > a').attr("href", link);
    $('.breadcrumb-item.display-none').removeClass("display-none");
    $('.m-0.text-dark').html(title);
}



    

