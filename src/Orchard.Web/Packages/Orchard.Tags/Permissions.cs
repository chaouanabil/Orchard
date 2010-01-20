﻿using System.Collections.Generic;
using System.Linq;
using Orchard.Security.Permissions;

namespace Orchard.Tags {
    public class Permissions : IPermissionProvider {
        public static readonly Permission ManageTags = new Permission { Description = "Manage tags", Name = "ManageTags" };
        public static readonly Permission CreateTag = new Permission { Description = "Create tag", Name = "CreateTag" };
        public static readonly Permission ApplyTag = new Permission { Description = "Applying a Tag", Name = "ApplyTag" };

        public string PackageName {
            get {
                return "Tags";
            }
        }

        public IEnumerable<Permission> GetPermissions() {
            return new Permission[] {
                ManageTags,
                CreateTag,
                ApplyTag,
            };
        }

        public IEnumerable<PermissionStereotype> GetDefaultStereotypes() {
            return Enumerable.Empty<PermissionStereotype>();
        }

    }
}
