## User Stories

As a faculty member I can:
- [ ] Add new classes to the registration catalog
    - [ ] Classes should have department (BIO, CS, etc), number
    - [ ] Classes may not have an assigned instructor
- [ ] Change the registration details for a class
- [ ] Remove a class from the registration catalog (this should unregister all registered students)
    - [ ] Done through MySQL

As a student, I can:
- [ ] Register a new account with the system (must be secured with a password)
    - [ ] User will enter username, password, email, first name, and last name
        - [ ] Password should be hashed and salted using SHA2
    - [ ] User will have a unique id
        - [ ] Use MySQL's auto-increment primary key
    - [ ] Ensure usernames and emails are unique
- [ ] Login with my existing credentials
    - [ ] Login with username/email and password
        - [X] **No "forgot password" feature** (yet)
    - [ ] Check if session/auth tokens are required
- [ ] View classes available for registration
    - [ ] Classes where registered < capacity
- [ ] Register for an open and available class
    - [ ] If other use takes last spot, user cannot register (registration failed)
        - [ ] Potential race condition
- [ ] Cancel my registration for a class (if within window)
    - [ ] Elaborate
- [ ] View the classes that I have registered for

## Minimum Features
- [ ] Basic validation (e.g. no registration for classes outside of registration window, etc.)
- [ ] Unit tests for all business-logic classes
- [ ] All exceptions are properly caught and handled
- [ ] Proper use of OOP principles
- [ ] Documentation (all classes and methods have basic documentation)
- [ ] Referential integrity (e.g. if a class is removed from the catalog, no students should be registered for it)
- [ ] Logging messages and exceptions to a file using a .NET logging framework (e.g. Log4J2, SLF4J, etc.)


## Tech Stack
- [ ] C#.NET
- [ ] NuGet?
- [ ] MySQL
- [ ] Git SCM (hosted on GitHub)