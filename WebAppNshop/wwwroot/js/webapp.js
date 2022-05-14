
function toggleMenu() {
        document.getElementById("menu-user-dropdown-toggle").classList.toggle("switch-menu-user");
}

var loadFile = function (event) {//detail product
            var image = document.getElementById('output-img-comment');
    image.src = URL.createObjectURL(event.target.files[0]);
};


    //Product Cart
    $('.like-btn').on('click', function () {
        $(this).toggleClass('is-active');
    });
    $('.minus-btn').on('click', function (e) {
        e.preventDefault();
        var $this = $(this);
        var $input = $this.closest('div').find('input');
        var value = parseInt($input.val());

        if (value > 1) {
            value = value - 1;
        } else {
            value = 1;
        }

        $input.val(value);

    });

    $('.plus-btn').on('click', function (e) {
        e.preventDefault();
        var $this = $(this);
        var $input = $this.closest('div').find('input');
        var value = parseInt($input.val());
        if (value < 100) {
            value = value + 1;
        } else {
            value = 100;
        }

        $input.val(value);
    });


