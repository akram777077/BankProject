using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Numerics;
using System.Security.Policy;

public class User
{
    private string _id;
    private string _firstName;
    private string _lastName;
    private string _userName;
    private string _password;
    private string _email;
    private string _phone;
    private string _address;
    private DateTime _dateOfBirth;

    public User()
    {
        _id = string.Empty;
        _firstName = string.Empty;
        _lastName = string.Empty;
        _userName = string.Empty;
        _password = string.Empty;
        _email = string.Empty;
        _phone = string.Empty;
        _address = string.Empty;
        _dateOfBirth = DateTime.MinValue;
    }
    public User(string id, string firstName, string lastName, string userName, string password, string email, string phone, string address, DateTime dateOfBirth)
    {
        _id = id;
        _firstName = firstName;
        _lastName = lastName;
        _userName = userName;
        _password = password;
        _email = email;
        _phone = phone;
        _address = address;
        _dateOfBirth = dateOfBirth;
    }

    public string Id
    {
        get => _id;
        set => _id = value;
    }

    public string FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    public string UserName
    {
        get => _userName;
        set => _userName = value;
    }

    public string Password
    {
        get => _password;
        set => _password = value;
    }

    public string Email
    {
        get => _email;
        set => _email = value;
    }

    public string Phone
    {
        get => _phone;
        set => _phone = value;
    }

    public string Address
    {
        get => _address;
        set => _address = value;
    }

    public DateTime DateOfBirth
    {
        get => _dateOfBirth;
        set => _dateOfBirth = value;
    }

    public string toLine(string separator, int key)
    {
        System.Text.StringBuilder result = new System.Text.StringBuilder();
        result.Append(_id).Append(separator);
        result.Append(_firstName).Append(separator);
        result.Append(_lastName).Append(separator);
        result.Append(_userName).Append(separator);
        result.Append(_password).Append(separator);
        result.Append(_email).Append(separator);
        result.Append(_phone).Append(separator);
        result.Append(_address).Append(separator);
        result.Append(_dateOfBirth.ToShortDateString());
        for (int a = 0; a < result.Length; a++)
            result[a] = (char)((int)result[a] + key);
        return result.ToString();
    }
    private static string[] splitIt(string line, string separator, int key)
    {
        System.Text.StringBuilder temp = new System.Text.StringBuilder();
        temp.Append(line);
        for (int i = 0; i < temp.Length; i++)
            temp[i] = (char)((int)temp[i] - key);
        line = temp.ToString();
        string[] result = line.Split(new string[] { separator }, StringSplitOptions.None);
        return result;
    }
    public static User lineToUser(string line, string separator, int key)
    {
        string[] rsu = splitIt(line, separator, key);
        DateTime.TryParse(rsu[8], out DateTime date);
        return new User(rsu[0], rsu[1], rsu[2], rsu[3], rsu[4], rsu[5], rsu[6], rsu[7], date);
    }
}