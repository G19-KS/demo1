var SearchKh = function () {
    debugger;
    $.ajax({
        type: 'post',
        url: '/QuanLiKhachSan/TimKhach',
        data: { data: $("#searchKH").val() },
        dataType: 'json',
        success: function (kh) {
            var listKh;
            for (var i = 0; i < kh.length; i++) {
                listKh += "<tr><td>" + kh[i].MaKH + "</td><td>" + kh[i].MaLoaiKhach + "</td><td>" + kh[i].TenKhach + "</td><td>" + kh[i].GioiTinh + "</td><td>" + kh[i].CMND + "</td><td>" + "</td><td>" + kh[i].DiaChi + "</td></tr>";

            }
            $("#dsKH").html(listKh);
        }

    });
};