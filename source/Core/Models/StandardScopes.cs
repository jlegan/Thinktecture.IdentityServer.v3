﻿/*
 * Copyright 2014 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System.Collections.Generic;
using System.Linq;

namespace Thinktecture.IdentityServer.Core.Models
{
    public static class StandardScopes
    {
        public static IEnumerable<Scope> All
        {
            get
            {
                return new[]
                {
                    OpenId,
                    Profile,
                    Email,
                    Phone,
                    Address
                };
            }
        }

        public static IEnumerable<Scope> AllAlwaysInclude
        {
            get
            {
                return new[]
                {
                    OpenId,
                    ProfileAlwaysInclude,
                    EmailAlwaysInclude,
                    PhoneAlwaysInclude,
                    AddressAlwaysInclude
                };
            }
        }

        public static Scope OpenId
        {
            get
            {
                return new Scope
                {
                    Name = Constants.StandardScopes.OpenId,
                    Required = true,
                    Type = ScopeType.Identity,
                    Claims = new List<ScopeClaim>
                    {
                        new ScopeClaim(Constants.ClaimTypes.Subject, alwaysInclude: true)
                    }
                };
            }
        }

        public static Scope Profile
        {
            get
            {
                return new Scope
                {
                    Name = Constants.StandardScopes.Profile,
                    Type = ScopeType.Identity,
                    Emphasize = true,
                    Claims = (Constants.ScopeToClaimsMapping[Constants.StandardScopes.Profile].Select(claim => new ScopeClaim(claim)))
                };
            }
        }

        public static Scope ProfileAlwaysInclude
        {
            get
            {
                return new Scope
                {
                    Name = Constants.StandardScopes.Profile,
                    Type = ScopeType.Identity,
                    Emphasize = true,
                    Claims = (Constants.ScopeToClaimsMapping[Constants.StandardScopes.Profile].Select(claim => new ScopeClaim(claim, alwaysInclude: true)))
                };
            }
        }

        public static Scope Email
        {
            get
            {
                return new Scope
                {
                    Name = Constants.StandardScopes.Email,
                    Type = ScopeType.Identity,
                    Emphasize = true,
                    Claims = (Constants.ScopeToClaimsMapping[Constants.StandardScopes.Email].Select(claim => new ScopeClaim(claim)))
                };
            }
        }

        public static Scope EmailAlwaysInclude
        {
            get
            {
                return new Scope
                {
                    Name = Constants.StandardScopes.Email,
                    Type = ScopeType.Identity,
                    Emphasize = true,
                    Claims = (Constants.ScopeToClaimsMapping[Constants.StandardScopes.Email].Select(claim => new ScopeClaim(claim, alwaysInclude: true)))
                };
            }
        }

        public static Scope Phone
        {
            get
            {
                return new Scope
                {
                    Name = Constants.StandardScopes.Phone,
                    Type = ScopeType.Identity,
                    Emphasize = true,
                    Claims = (Constants.ScopeToClaimsMapping[Constants.StandardScopes.Phone].Select(claim => new ScopeClaim(claim)))
                };
            }
        }

        public static Scope PhoneAlwaysInclude
        {
            get
            {
                return new Scope
                {
                    Name = Constants.StandardScopes.Phone,
                    Type = ScopeType.Identity,
                    Emphasize = true,
                    Claims = (Constants.ScopeToClaimsMapping[Constants.StandardScopes.Phone].Select(claim => new ScopeClaim(claim, alwaysInclude: true)))
                };
            }
        }

        public static Scope Address
        {
            get
            {
                return new Scope
                {
                    Name = Constants.StandardScopes.Address,
                    Type = ScopeType.Identity,
                    Emphasize = true,
                    Claims = (Constants.ScopeToClaimsMapping[Constants.StandardScopes.Address].Select(claim => new ScopeClaim(claim)))
                };
            }
        }

        public static Scope AddressAlwaysInclude
        {
            get
            {
                return new Scope
                {
                    Name = Constants.StandardScopes.Address,
                    Type = ScopeType.Identity,
                    Emphasize = true,
                    Claims = (Constants.ScopeToClaimsMapping[Constants.StandardScopes.Address].Select(claim => new ScopeClaim(claim, alwaysInclude: true)))
                };
            }
        }

        public static Scope AllClaims
        {
            get
            {
                return new Scope
                {
                    Name = Constants.StandardScopes.AllClaims,
                    Type = ScopeType.Identity,
                    Emphasize = true,
                    IncludeAllClaimsForUser = true
                };
            }
        }

        public static Scope Roles
        {
            get
            {
                return new Scope
                {
                    Name = Constants.StandardScopes.Roles,
                    Type = ScopeType.Identity,
                    Emphasize = true,
                    Claims = new [] 
                    {
                        new ScopeClaim(Constants.ClaimTypes.Role)
                    }
                };
            }
        }

        public static Scope RolesAlwaysInclude
        {
            get
            {
                return new Scope
                {
                    Name = Constants.StandardScopes.Roles,
                    Type = ScopeType.Identity,
                    Emphasize = true,
                    Claims = new[] 
                    {
                        new ScopeClaim(Constants.ClaimTypes.Role, alwaysInclude: true)
                    }
                };
            }
        }

        public static Scope OfflineAccess
        {
            get
            {
                return new Scope
                {
                    Name = Constants.StandardScopes.OfflineAccess,
                    Type = ScopeType.Resource,
                    Emphasize = true
                };
            }
        }
    }
}