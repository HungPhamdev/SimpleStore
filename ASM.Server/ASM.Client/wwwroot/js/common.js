function addCart(id) {
    $("#imgCart").attr("src", '/images/cartA.png');
    $("#imgBusy_" + id).show();
    setTimeout(function () {        
        $("#imgBusy_" + id).hide();
    }, 500);
}

function delCart(id) {
    $("#tr_" + id).hide();
}

function clearCart() {
    $("#imgCart").attr("src", '/images/cart.png');
}

function refreshMenu(obj) {
    //$("#imgCart").attr("src", '/images/cart.png');
    if (obj != "") {
        var html = '<li class="nav-item"><a class="nav-link text-dark" id="information" href="/Info"><i class="far fa-smile"></i> Xin chào ' + obj.email + '! | </a></li>';
        html += '<li class="nav-item"><a class="nav-link text-dark" id="history" href="/History"><i class="fas fa-shopping-cart"></i> Đơn hàng | </a></li>'
        html += '<li class="nav-item"><a class="nav-link text-dark" id="logout" href="/Logout"><i class="fas fa-sign-out-alt"></i> Đăng xuất  </a></li>';
        $("#navLogin").html(html);
    }
    else {
        var html = '<li class="nav-item">';
        html += '<a class="nav-link text-dark" id="register" href="/Register"><i class="far fa-registered"></i> Đăng ký</a></li>';
        html += '<a class="nav-link text-dark" id="login" href="/Login"><i class="fas fa-sign-in-alt"></i> Đăng nhập</a></li>';
        $("#navLogin").html(html);
    }
}
