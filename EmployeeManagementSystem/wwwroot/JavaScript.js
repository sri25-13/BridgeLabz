function validate() {
    if (idvalidation()) {
        if (fnamevalidation()) {
            if (lnamevalidation()) {
                if (emailvalid()) {
                    if (emailvalidation()) {
                        if (passwordvalidation()) {
                        }
                    }
                }
            }
        }
    }
}
function idvalidation() {
    var id = $('#Id').val();
    if (id.length < 1) {
        alert("firstname is required");
        return false;
    }
}
function fnamevalidation() {
    var fname = $('#Firstname').val();
    if (fname.length < 1) {
        alert("firstname is required");
        return false;
    }
}
function lnamevalidation() {
    var lname = $('#Lastname').val();
    if (lname.length < 1) {
        alert("lastname is required");
        return false;
    }
}
function emailvalid() {
    var email = $('#Email').val();
    if (email.length < 1) {
        alert("email is required");
        return false;
    }
}
function emailvalidation() {
    var email = $('#Email').val();
    var regex = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
    if (regex.test(email) == false) {
        alert("Invalid Email Address");
        return false;
    }
}

function passwordvalidation() {
    var password = $('#Password').val();
    if (password.length < 5) {
        alert("password should have minimum 5 characters");
        return false;
    }
}
