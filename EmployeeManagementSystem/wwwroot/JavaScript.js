function validate() {
    var Firstname = $('#Firstname').val();
    var Lastname = $('#Lastname').val();
    var Email = $('#Email').val();
    var Password = $('#Password').val();
    var Id = $('Id').val();
    console.log(Firstname, Lastname, Email, Password, Id);

    if (Id.length < 1) {
        $('#Id').after('<span class="error">This field is required</span>');
    }

    if (Firstname.length < 1) {
        $('#Firstname').after('<span class="error">This field is required</span>');
    }
    if (Password.length < 5) {
        $('#Password').after('<span class="error">Password must be at least 5 characters long</span>');
    }
    if (Lastname.length < 1) {
        $('#Lastname').after('<span class="error">This field is required</span>');
    }
    if(Email.length < 1) {
        $('#Email').after('<span class="error">This field is required</span>');
    }
}
    function ValidateEmail() {
        var regEx = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
        var validEmail = regEx.test(Email);
        if (validEmail == false) {
            $('#Email').after('<span class="error">invalid email</span>');
            return false;
        }
        else {
            return true;
        }
    }
    

