$(document).ready(function () {
    $('.button')
        .popup()
        ;
    $("#sidebar").click(function () {
        $('.ui.sidebar')
            .sidebar('toggle');
    });
    var
        content = [{
            title: 'آموزش سی شارپ',
            description: 'An Animal',
        },
        {
            title: 'Cow',
            description: 'Another Animal',
        }
        ];
    $('.ui.search')
        .search({
            source: content,
            searchFields: [
                'title'
            ],
        });
    $(".item.itemnavtop").hover(function () {
        $(this).addClass("active");
    }, function () {
        $(this).removeClass("active");
    });
    $('.ui.accordion')
        .accordion()
        ;
});