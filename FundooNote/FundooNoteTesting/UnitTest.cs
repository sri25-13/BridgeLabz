// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Tests.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="sriharshini"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooNoteTesting
{
    using Manager.ManagerImplementation;
    using Model.Account;
    using Model.Collaborators;
    using Model.Label;
    using Model.Notes;
    using NUnit.Framework;
    using Repository.RepositoryImplementation;

    /// <summary>
    /// class for NunitTesting of Fundoo
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// TestMethod for Login
        /// </summary>
        [Test]
        public void LoginTest()
        {
            LoginModel login = new LoginModel();
            login.Email = "sriharshinirao25@gmail.com";
            login.Password = "harshini@25@";
            AccountManager manager = new AccountManager();
            Assert.IsNotNull(manager.Login(login));
        }

        /// <summary>
        /// Test Method for Registering
        /// </summary>
        [Test]
        public void RegisterTest()
        {
            RegisterModel register = new RegisterModel();
            register.Firstname = "ab";
            register.Lastname = "abc";
            register.Email = "abcd@gmail.com";
            register.Password = "abcd";
            AccountManager manager = new AccountManager();
            Assert.IsNotNull(manager.Register(register));
        }

        /// <summary>
        /// TestMethod for ForgotPassword
        /// </summary>
        [Test]
        public void ForgotPasswordTest()
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.Email = "sriharshinirao25@gmail.com";
            var result = new AccountManager();
            Assert.IsNotNull(result.ForgotPassword(forgot));
        }

        /// <summary>
        /// Test Method for ResetPassword
        /// </summary>
        [Test]
        public void ResetPasswordTest()
        {
            ResetPassword reset = new ResetPassword()
            {
                Email = "ab@gmail.com",
                Password = "abc",
                NewPassword = "ab",
                ConfirmPassword = "ab"
            };
            AccountManager manager = new AccountManager();
            Assert.IsNotNull(manager.ResetPassword(reset));
        }

        /// <summary>
        /// Test Method for EmailLogin
        /// </summary>
        [Test]
        public void EmailLoginTest()
        {
            LoginModel login = new LoginModel()
            {
                Email = "ab@gmail.com",
                Password = "ab"
            };
            AccountManager manager = new AccountManager();
            Assert.IsNotNull(manager.EmailLogin(login));
        }

        /// <summary>
        /// Test Method for LoggingIn Facebook
        /// </summary>
        [Test]
        public void FaceBookLoginTest()
        {
            LoginModel login = new LoginModel()
            {
                Email = "ab@gmail.com",
                Password = "ab"
            };
            AccountManager manager = new AccountManager();
            Assert.IsNotNull(manager.FacebookLogin(login));
        }
        [Test]
        public void AddNoteTest()
        {
            NotesModel notesModel1 = new NotesModel()
            {
                NoteId = 456,
                Email = "sriharshin25@gmail.com",
                Title = ".net",
                Description = "jhgfc",
                Archeive = false,
                Pin = false,
                ChangeColor = "green",
                AddImg = "qsd",
                Trash = false,
            };
            NoteManager noteManager = new NoteManager();
            Assert.IsNotNull(noteManager.AddNotes(notesModel1));
        }
        [Test]
        public void UpdateNoteTest()
        {
            NotesModel notes = new NotesModel();
            notes.NoteId = 1;
            notes.Title = "routine";
            notes.Description = "jhg";
            notes.ChangeColor = "blue";
            notes.AddImg = "qsd";

            NoteManager manager = new NoteManager();
            Assert.IsNotNull(manager.Update(notes.NoteId, notes.Title, notes.Description, notes.ChangeColor, notes.AddImg));
        }
        [Test]
        public void DeleteNoteTest()
        {
            NotesModel model = new NotesModel();
            model.NoteId = 1;
            NoteManager noteManager = new NoteManager();
            Assert.IsNotNull(noteManager.Delete(model.NoteId));
        }
        [Test]
        public void AddLabelTest()
        {
            Labelmodel labelmodel = new Labelmodel();
            labelmodel.LabelId = 12;
            labelmodel.LabelName = "harsgini";
            LabelManager manager = new LabelManager();
            Assert.IsNotNull(manager.AddLabel(labelmodel.LabelName,labelmodel.LabelId));
        }
        [Test]
        public void DeleteLabelTest()
        {
            Labelmodel labelmodel = new Labelmodel();
            labelmodel.LabelId = 1234;
            LabelManager manager = new LabelManager();
            Assert.IsNotNull(manager.DeleteLabel(labelmodel.LabelId));
        }
        [Test]
        public void UpdateLabelTest()
        {
            Labelmodel labelmodel = new Labelmodel();
            labelmodel.LabelId = 2;
            labelmodel.LabelName = "kjhgf";
            LabelManager manager = new LabelManager();
            Assert.IsNotNull(manager.UpdateLabel(labelmodel.LabelName, labelmodel.LabelId));
        }
        [Test]
        public void AddCollaboratorTest()
        {
            CollaboratorModel model = new CollaboratorModel();
            model.Id = 1;
            model.NoteId = 2;
            model.SenderEmail = "abc@gmail.com";
            model.ReceiverEmail = "harsh@gmail.com";
            CollaboratorManager manager = new CollaboratorManager();
            Assert.IsNotNull(manager.AddCollaborator(model));
        }
        [Test]
        public void DeleteCollaborator()
        {
            CollaboratorModel model = new CollaboratorModel();
            model.Id = 1;
            CollaboratorManager manager = new CollaboratorManager();
            Assert.IsNotNull(manager.DeleteCollaborator(model.Id));
        }
    }
}

    
