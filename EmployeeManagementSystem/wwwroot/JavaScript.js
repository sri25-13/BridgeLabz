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
    if (Lastname.length < 1) {
        $('#Lastname').after('<span class="error">This field is required</span>');
    }
    if (Email.length >) {
        $('#Email').after('<span class="error">This field is required</span>');
    }
    else {
        var regEx = /^[A-Z0-9][A-Z0-9._%+-]{0,63}@(?:[A-Z0-9-]{1,63}\.){1,125}[A-Z]{2,63}$/;
        var validEmail = regEx.test(Email);
        if (!validEmail) {
            $('#Email').after('<span class="error">Enter a valid email</span>');
        }
    }
    if (Password.length < 5) {
        $('#Password').after('<span class="error">Password must be at least 5 characters long</span>');
    }
}
function ValidateEmail(mail) {
    if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(myForm.emailAddr.value)) {
        return (true)
    }
    alert("You have entered an invalid email address!")
    return (false)
}