﻿using System;

namespace Shoc.Identity.Model.User;

/// <summary>
/// Create User Model entity
/// </summary>
public class UserCreateModel
{
    /// <summary>
    /// The user id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// The email address
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// If email is verified
    /// </summary>
    public bool EmailVerified { get; set; }

    /// <summary>
    /// The username
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// The user type
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// The user state
    /// </summary>
    public string UserState { get; set; }

    /// <summary>
    /// The phone number
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// If phone is verified
    /// </summary>
    public bool PhoneVerified { get; set; }

    /// <summary>
    /// The first name
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// The last name
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// The full name of user
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// The picture uri of the user
    /// </summary>
    public string PictureUri { get; set; }

    /// <summary>
    /// The gender 
    /// </summary>
    public string Gender { get; set; }

    /// <summary>
    /// The user timezone
    /// </summary>
    public string Timezone { get; set; }

    /// <summary>
    /// The birth date
    /// </summary>
    public DateTime? BirthDate { get; set; }

    /// <summary>
    /// The user's country
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    /// The state of user
    /// </summary>
    public string State { get; set; }

    /// <summary>
    /// The city of user
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// The postal code of user
    /// </summary>
    public string Postal { get; set; }

    /// <summary>
    /// The first address
    /// </summary>
    public string Address1 { get; set; }

    /// <summary>
    /// The second address
    /// </summary>
    public string Address2 { get; set; }

    /// <summary>
    /// The given password
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// The password hash
    /// </summary>
    public string PasswordHash { get; set; }
}