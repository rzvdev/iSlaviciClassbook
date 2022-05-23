using iSlavici.Controls;
using iSlavici.Models;
using System.Collections.Generic;

namespace iSlavici.Components.interfaces
{
    public interface IFiltrableUser
    {
        List<UserListModel> GetUserList();
        void SetUserList(List<UserListModel> userList);

    }
}
