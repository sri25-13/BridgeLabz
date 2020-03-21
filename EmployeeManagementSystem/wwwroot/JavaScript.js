function validate() {
    var fname = $('#Firstname').val();
    var lname = $('#Lastname').val();
    var email = $('#Email').val();
    var password = $('#Password').val();
    if (fname()) {

        if (lname()) {
            if (email()) {

                if (password()) {
                }
            }
        }
    }
}
function fname() {
    if (fname.length < 1) {
        alert("firstname is required");
    }
}
function lname() {
    if (lname.length < 1) {
        alert("lastname is required");
    }
}
function email() {
    var regex = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
    if (email.length < 1) {
        alert("email is required");

        if (regex.test(email) == false) {
            alert("Invalid Email Address");
        }
    }
}
function password() {
    if (password.length < 5) {
        alert("password should have minimum 5 characters");
    }
}
