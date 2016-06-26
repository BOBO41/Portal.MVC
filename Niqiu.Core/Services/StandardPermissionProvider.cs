using System.Collections.Generic;
using Niqiu.Core.Domain.Security;
using Niqiu.Core.Domain.User;

namespace Niqiu.Core.Services
{
    /// <summary>
    /// Standard permission provider
    /// </summary>
    public partial class StandardPermissionProvider : IPermissionProvider
    {
        //�����̨
        public static readonly PermissionRecord AccessAdminPanel = new PermissionRecord { Name = "�����̨", SystemName = "AccessAdminPanel", Category = "Standard" };
        //�����Ʒ
        public static readonly PermissionRecord ManageProducts = new PermissionRecord { Name = "�����Ʒ", SystemName = "ManageProducts", Category = "Catalog" };
        //�������
        public static readonly PermissionRecord ManageCategories = new PermissionRecord { Name = "�������", SystemName = "ManageCategories", Category = "Catalog" };
        //�����û�
        public static readonly PermissionRecord ManageUsers = new PermissionRecord { Name = "�����û�", SystemName = "ManageUsers", Category = "Users" };
        //������
        public static readonly PermissionRecord ManageOrders = new PermissionRecord { Name = "������", SystemName = "ManageOrders", Category = "Orders" };
        //��������
        public static readonly PermissionRecord ManageNews = new PermissionRecord { Name = "��������", SystemName = "ManageNews", Category = "Content Management" };
        //������ ���İ�
        public static readonly PermissionRecord ManageBlog = new PermissionRecord { Name = "������", SystemName = "ManageBlog", Category = "Content Management" };
        //������
        public static readonly PermissionRecord ManagePlugins = new PermissionRecord { Name = "������", SystemName = "ManagePlugins", Category = "Configuration" };
        //������
        public static readonly PermissionRecord ManageTopics = new PermissionRecord { Name = "������", SystemName = "ManageTopics", Category = "Content Management" };
        //������̳
        public static readonly PermissionRecord ManageForums = new PermissionRecord { Name = "������̳", SystemName = "ManageForums", Category = "Content Management" };
        //����ϵͳ��־
        public static readonly PermissionRecord ManageSystemLog = new PermissionRecord { Name = "������־", SystemName = "ManageSystemLog", Category = "Configuration" };
     
        //�����������
        public static readonly PermissionRecord ManageDownloadFiles = new PermissionRecord { Name = "�����ļ�", SystemName = "DownloadFiles", Category = "Content Management" };
        //������ʦ-->ָ��˭�ǹ���ʦ
        public static readonly PermissionRecord ManageEngineers = new PermissionRecord { Name = "������ʦ", SystemName = "ManageEngineers", Category = "Users" };
        //����ʦ����Ȩ���ش�����
        public static readonly PermissionRecord ManageQuestiones = new PermissionRecord { Name = "��������", SystemName = "ManageQuestiones", Category = "Content Management" };

        //���ͻ���Ȩ�� �����򹤳�ʦ����
        public static readonly PermissionRecord AskQuestion = new PermissionRecord { Name = "�����ʴ�", SystemName = "AskQuestion", Category = "Support" };

        //�����̻�
        public static readonly PermissionRecord ManageTenant = new PermissionRecord { Name = "�����̻�", SystemName = "ManageTenant", Category = "Users" };

        public static readonly PermissionRecord SearchOrder = new PermissionRecord { Name = "������ѯ", SystemName = "SearchOrder", Category = "Users" };


        //public store permissions
        public static readonly PermissionRecord DisplayPrices = new PermissionRecord { Name = "Public store. Display Prices", SystemName = "DisplayPrices", Category = "PublicStore" };
        public static readonly PermissionRecord EnableShoppingCart = new PermissionRecord { Name = "Public store. Enable shopping cart", SystemName = "EnableShoppingCart", Category = "PublicStore" };
        public static readonly PermissionRecord EnableWishlist = new PermissionRecord { Name = "Public store. Enable wishlist", SystemName = "EnableWishlist", Category = "PublicStore" };
        public static readonly PermissionRecord PublicStoreAllowNavigation = new PermissionRecord { Name = "Public store. Allow navigation", SystemName = "PublicStoreAllowNavigation", Category = "PublicStore" };
        public static readonly PermissionRecord AccessClosedStore = new PermissionRecord { Name = "Public store. Access a closed store", SystemName = "AccessClosedStore", Category = "PublicStore" };




        public virtual IEnumerable<PermissionRecord> GetPermissions()
        {
            return new[] 
            {
                AccessAdminPanel,ManageProducts,ManageCategories,ManageUsers,ManageOrders,ManageNews,ManageBlog,ManagePlugins,ManageTopics,ManageForums,ManageSystemLog,ManageDownloadFiles,
                ManageEngineers,ManageQuestiones,ManageTenant,SearchOrder,DisplayPrices,EnableShoppingCart,EnableWishlist,PublicStoreAllowNavigation,AccessClosedStore
            };
        }


        public virtual IEnumerable<DefaultPermissionRecord> GetDefaultPermissions()
        {
            return new[] 
            {
                new DefaultPermissionRecord 
                {
                    UserRoleSystemName = SystemUserRoleNames.Administrators,
                    PermissionRecords =GetPermissions() 
                },
                new DefaultPermissionRecord
                {
                   UserRoleSystemName   = SystemUserRoleNames.Admin,
                   PermissionRecords = new []
                   {
                       AccessAdminPanel,
                       SearchOrder,
                       ManageUsers,
                   }
                },

               new DefaultPermissionRecord
                {
                   UserRoleSystemName   = SystemUserRoleNames.Employeer,
                   PermissionRecords = new []
                   {
                       AccessAdminPanel,
                       SearchOrder,
                   }
                },
                  new DefaultPermissionRecord
                {
                   UserRoleSystemName   = SystemUserRoleNames.Registered,
                     PermissionRecords = new []
                   {
                       DisplayPrices,
                       EnableShoppingCart,
                       EnableWishlist,
                       PublicStoreAllowNavigation
                   }
                },
                  new DefaultPermissionRecord
                {
                   UserRoleSystemName   = SystemUserRoleNames.Guests,
                      PermissionRecords = new []
                   {
                       DisplayPrices,
                       EnableShoppingCart,
                       EnableWishlist,
                       PublicStoreAllowNavigation
                   }
                },
 
            };
        }
    }
}