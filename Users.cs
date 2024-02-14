using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Reflection;

public class Users
{

	private List<User> _users;
	private string _fileName;
	private string _separator;
	private int _key;

	public Users(string fileName , string _separator , int key)
	{
		_users = new List<User>();
		this._fileName = fileName;
		this._separator = _separator;
		this._key = key;
	}
	public void addUser(User user)
	{
		_users.Add(user);
		save();
	}
	public int getUserID(string ID)
	{
		for(int i=0;i<_users.Count;i++)
		{
			if (_users[i].Id == ID)
				return i; 
		}
		return -1;
	}
	public int getUserUserName(string UserName)
	{
        for (int i = 0; i<_users.Count; i++)
        {
			if (_users[i].UserName == UserName)
				return i;
        }
        return -1;
    }
	public void deleteUserID(User target)
	{
		_users.Remove(target);
		save();
	}
	public void save()
	{
		this.clearFile();
		for (int i = 0; i < _users.Count; i++)
            File.AppendAllText(this._fileName, _users[i].toLine(_separator, _key)+"\n");
		
	}
	public void load()
	{
		string[] result = File.ReadAllLines(this._fileName);
		foreach (string line in result)
			_users.Add(User.lineToUser(line, _separator, _key));
	}
	public void clearFile()
	{
		File.Delete(this._fileName);
	}
	public User getUserByIndex(int index)
	{
		return (index!=-1)?_users[index]:null;
	}
	public void changeUser(int index,User newUser)
	{
		_users[index] = newUser;
		save();
	}
}
