﻿using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using Sseko.Core.Base;
using Sseko.Core.Enums;

namespace AspNetCore.Identity.DocumentDb
{
    /// <summary>
    /// Represents a user in the identity system for the <see cref="Stores.DocumentDbUserStore{TUser, TRole}"/> with the role type defaulted to <see cref="DocumentDbIdentityRole"/>
    /// </summary>
    public class DocumentDbIdentityUser : DocumentDbIdentityUser<DocumentDbIdentityRole>
    {
    }

    /// <summary>
    /// Represents a user in the identity system for the <see cref="Stores.DocumentDbUserStore{TUser, TRole}"/>
    /// </summary>
    public class DocumentDbIdentityUser<TRole> : DocumentBase
    {
        public DocumentDbIdentityUser() : base(DocumentType.DocumentDbIdentityUser)
        {
            this.Id = Guid.NewGuid().ToString();
            this.Logins = new List<UserLoginInfo>();
            this.Claims = new List<Claim>();
            this.PKey = "DocumentDbIdentityUser";
            this.DocumentType = DocumentType.DocumentDbIdentityUser;
        }
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "normalizedUserName")]
        public string NormalizedUserName { get; set; }

        [JsonProperty(PropertyName = "normalizedEmail")]
        public string NormalizedEmail { get; set; }

        [JsonProperty(PropertyName = "isEmailConfirmed")]
        public bool IsEmailConfirmed { get; set; }

        [JsonProperty(PropertyName = "phoneNumber")]
        public string PhoneNumber { get; internal set; }

        [JsonProperty(PropertyName = "isPhoneNumberConfirmed")]
        public bool IsPhoneNumberConfirmed { get; internal set; }

        [JsonProperty(PropertyName = "passwordHash")]
        public string PasswordHash { get; set; }

        [JsonProperty(PropertyName = "securityStamp")]
        public string SecurityStamp { get; set; }

        [JsonProperty(PropertyName = "isTwoFactorAuthEnabled")]
        public bool IsTwoFactorAuthEnabled { get; set; }

        [JsonProperty(PropertyName = "logins")]
        public IList<UserLoginInfo> Logins { get; set; }

        public string Role { get; set; }

        [JsonProperty(PropertyName = "claims")]
        public IList<Claim> Claims { get; set; }

        [JsonProperty(PropertyName = "lockoutEnabled")]
        public bool LockoutEnabled { get; set; }

        [JsonProperty(PropertyName = "lockoutEndDate")]
        public DateTimeOffset? LockoutEndDate { get; set; }

        [JsonProperty(PropertyName = "accessFailedCount")]
        public int AccessFailedCount { get; set; }
    }
}
