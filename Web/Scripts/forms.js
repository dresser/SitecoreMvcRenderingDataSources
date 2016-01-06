(function ($) {
    $('#subscription-form')
        .on('submit', 'form', function() {

            $.ajax({
                type: "POST",
                url: $(this).attr('action'),
                data: $(this).serialize(),
                success: function(data) {
                    alert('form was submitted successfully');
                }
            });
            return false;

        });
})(jQuery.noConflict());