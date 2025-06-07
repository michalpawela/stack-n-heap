./LinkedHeap.nuspec
---
<?xml version="1.0"?>
<package >
  <metadata>
    <id>LinkedHeap</id>
    <version>1.0.0</version>
    <authors>Hieronim Daniel, Michał Pawela</authors>
    <requireLicenseAcceptance>false</requireLicenseAcceptance>
    <license type="expression">MIT</license>
    <projectUrl>https://github.com/Hier0nim/LinkedHeap</projectUrl>
    <summary>Pointer-based stack and queue with a custom heap manager in C#.</summary>
    <description>Custom stack and queue implementation using pointer-based lists with a custom heap manager.</description>
    <releaseNotes>Initial release with stack, queue, and custom heap implementation.</releaseNotes>
    <tags>heap stack queue pointer datastructure</tags>
    <dependencies>
      <group targetFramework="net10.0">
        <!-- <dependency id="SomePackage" version="1.2.3" /> -->
        <dependency id="Microsoft.Extensions.DependencyInjection.Abstractions" version="10.0.0-preview.4.25258.110" />
      </group>
    </dependencies>
    <readme>README.md</readme>
    <repository type="git" url="https://github.com/Hier0nim/LinkedHeap" />
  </metadata>
  <files>
    <file src="LinkedHeap/bin/Release/net10.0/LinkedHeap.dll" target="lib/net10.0" />
    <file src="README.md" target="" />
  </files>
</package>


---
./LinkedHeap.slnx
---
﻿<Solution>
  <Configurations>
    <Platform Name="Any CPU" />
    <Platform Name="x64" />
    <Platform Name="x86" />
  </Configurations>
  <Project Path="LinkedHeap/LinkedHeap.csproj" />
  <Project Path="LinkedHeap.Tests/LinkedHeap.Tests.csproj" />
  <Project Path="LinkedHeap.Demo/LinkedHeap.Demo.csproj" />
</Solution>


---
./README.md
---
# LinkedHeap


---
./flake.lock
---
{
  "nodes": {
    "flake-compat": {
      "flake": false,
      "locked": {
        "lastModified": 1641205782,
        "narHash": "sha256-4jY7RCWUoZ9cKD8co0/4tFARpWB+57+r1bLLvXNJliY=",
        "owner": "edolstra",
        "repo": "flake-compat",
        "rev": "b7547d3eed6f32d06102ead8991ec52ab0a4f1a7",
        "type": "github"
      },
      "original": {
        "owner": "edolstra",
        "repo": "flake-compat",
        "type": "github"
      }
    },
    "flake-compat_2": {
      "flake": false,
      "locked": {
        "lastModified": 1641205782,
        "narHash": "sha256-4jY7RCWUoZ9cKD8co0/4tFARpWB+57+r1bLLvXNJliY=",
        "owner": "edolstra",
        "repo": "flake-compat",
        "rev": "b7547d3eed6f32d06102ead8991ec52ab0a4f1a7",
        "type": "github"
      },
      "original": {
        "owner": "edolstra",
        "repo": "flake-compat",
        "type": "github"
      }
    },
    "flake-utils": {
      "inputs": {
        "systems": "systems"
      },
      "locked": {
        "lastModified": 1731533236,
        "narHash": "sha256-l0KFg5HjrsfsO/JpG+r7fRrqm12kzFHyUHqHCVpMMbI=",
        "owner": "numtide",
        "repo": "flake-utils",
        "rev": "11707dc2f618dd54ca8739b309ec4fc024de578b",
        "type": "github"
      },
      "original": {
        "owner": "numtide",
        "repo": "flake-utils",
        "type": "github"
      }
    },
    "flake-utils_2": {
      "locked": {
        "lastModified": 1644229661,
        "narHash": "sha256-1YdnJAsNy69bpcjuoKdOYQX0YxZBiCYZo4Twxerqv7k=",
        "owner": "numtide",
        "repo": "flake-utils",
        "rev": "3cecb5b042f7f209c56ffd8371b2711a290ec797",
        "type": "github"
      },
      "original": {
        "owner": "numtide",
        "repo": "flake-utils",
        "type": "github"
      }
    },
    "flake-utils_3": {
      "locked": {
        "lastModified": 1644229661,
        "narHash": "sha256-1YdnJAsNy69bpcjuoKdOYQX0YxZBiCYZo4Twxerqv7k=",
        "owner": "numtide",
        "repo": "flake-utils",
        "rev": "3cecb5b042f7f209c56ffd8371b2711a290ec797",
        "type": "github"
      },
      "original": {
        "owner": "numtide",
        "repo": "flake-utils",
        "type": "github"
      }
    },
    "neorg": {
      "flake": false,
      "locked": {
        "lastModified": 1747755429,
        "narHash": "sha256-07QhATJIWAXNEN8liiWFWRS/hMs59Xjs4MF2lpKoaOE=",
        "owner": "nvim-neorg",
        "repo": "neorg",
        "rev": "f8c932adf75ba65cd015cdbcf9ed1b96814cf55e",
        "type": "github"
      },
      "original": {
        "owner": "nvim-neorg",
        "repo": "neorg",
        "type": "github"
      }
    },
    "neorg-overlay": {
      "inputs": {
        "flake-utils": "flake-utils",
        "neorg": "neorg",
        "neorg-telescope": "neorg-telescope",
        "nixpkgs": "nixpkgs",
        "norg": "norg",
        "norg-meta": "norg-meta"
      },
      "locked": {
        "lastModified": 1748568195,
        "narHash": "sha256-SI6Jk61VJU0SwysjcMUqHkFUITpfmpgv+VLKpTmcn0s=",
        "owner": "nvim-neorg",
        "repo": "nixpkgs-neorg-overlay",
        "rev": "b33c8336aad2ba353bdd37b6c0bb8f2dfc05d3ee",
        "type": "github"
      },
      "original": {
        "owner": "nvim-neorg",
        "repo": "nixpkgs-neorg-overlay",
        "type": "github"
      }
    },
    "neorg-telescope": {
      "flake": false,
      "locked": {
        "lastModified": 1744866747,
        "narHash": "sha256-tvbskEQ3+uOUlGKdqAFMlbF5Vw0A08XTwuWEs2aP64o=",
        "owner": "nvim-neorg",
        "repo": "neorg-telescope",
        "rev": "7fb6ca6a632c3c095601d379a664c0c1f802dc6c",
        "type": "github"
      },
      "original": {
        "owner": "nvim-neorg",
        "repo": "neorg-telescope",
        "type": "github"
      }
    },
    "nixCats": {
      "inputs": {
        "neorg-overlay": "neorg-overlay",
        "nixCats": "nixCats_2",
        "nixpkgs": [
          "nixpkgs"
        ],
        "plugins-hardtime-nvim": "plugins-hardtime-nvim",
        "plugins-jupytext-nvim": "plugins-jupytext-nvim",
        "plugins-log-highlight-nvim": "plugins-log-highlight-nvim",
        "plugins-neorg-interim-ls": "plugins-neorg-interim-ls",
        "plugins-nix-store-nvim": "plugins-nix-store-nvim",
        "plugins-roslyn-nvim": "plugins-roslyn-nvim",
        "plugins-rzls-nvim": "plugins-rzls-nvim",
        "plugins-venv-selector-nvim": "plugins-venv-selector-nvim"
      },
      "locked": {
        "lastModified": 1748945485,
        "narHash": "sha256-ro+cjcX3yzEd78+2ekKVuyLrNsMWErQ5yFXYQLBFu1A=",
        "owner": "Hier0nim",
        "repo": "nvim",
        "rev": "1368976ecda1b3d087acc92d8426e346cd5d2ff5",
        "type": "github"
      },
      "original": {
        "owner": "Hier0nim",
        "repo": "nvim",
        "type": "github"
      }
    },
    "nixCats_2": {
      "locked": {
        "lastModified": 1748230488,
        "narHash": "sha256-CktYY2rcFPJ3Tbz5H/nDnkhaO18nrLGdWa1mH7V9X5Q=",
        "owner": "BirdeeHub",
        "repo": "nixCats-nvim",
        "rev": "2a2f15a6c085524ac121f5da9a73ee2155c53d70",
        "type": "github"
      },
      "original": {
        "owner": "BirdeeHub",
        "repo": "nixCats-nvim",
        "type": "github"
      }
    },
    "nixpkgs": {
      "locked": {
        "lastModified": 1748506378,
        "narHash": "sha256-oS0Gxh63Df8b8r04lqEYDDLKhHIrVr9/JLOn2bn8JaI=",
        "owner": "NixOS",
        "repo": "nixpkgs",
        "rev": "3866ad91cfc172f08a6839def503d8fc2923c603",
        "type": "github"
      },
      "original": {
        "owner": "NixOS",
        "ref": "nixpkgs-unstable",
        "repo": "nixpkgs",
        "type": "github"
      }
    },
    "nixpkgs_2": {
      "locked": {
        "lastModified": 1644486793,
        "narHash": "sha256-EeijR4guVHgVv+JpOX3cQO+1XdrkJfGmiJ9XVsVU530=",
        "owner": "NixOS",
        "repo": "nixpkgs",
        "rev": "1882c6b7368fd284ad01b0a5b5601ef136321292",
        "type": "github"
      },
      "original": {
        "owner": "NixOS",
        "ref": "nixpkgs-unstable",
        "repo": "nixpkgs",
        "type": "github"
      }
    },
    "nixpkgs_3": {
      "locked": {
        "lastModified": 1644486793,
        "narHash": "sha256-EeijR4guVHgVv+JpOX3cQO+1XdrkJfGmiJ9XVsVU530=",
        "owner": "NixOS",
        "repo": "nixpkgs",
        "rev": "1882c6b7368fd284ad01b0a5b5601ef136321292",
        "type": "github"
      },
      "original": {
        "owner": "NixOS",
        "ref": "nixpkgs-unstable",
        "repo": "nixpkgs",
        "type": "github"
      }
    },
    "nixpkgs_4": {
      "locked": {
        "lastModified": 1748929857,
        "narHash": "sha256-lcZQ8RhsmhsK8u7LIFsJhsLh/pzR9yZ8yqpTzyGdj+Q=",
        "owner": "nixos",
        "repo": "nixpkgs",
        "rev": "c2a03962b8e24e669fb37b7df10e7c79531ff1a4",
        "type": "github"
      },
      "original": {
        "owner": "nixos",
        "ref": "nixos-unstable",
        "repo": "nixpkgs",
        "type": "github"
      }
    },
    "norg": {
      "inputs": {
        "flake-compat": "flake-compat",
        "flake-utils": "flake-utils_2",
        "nixpkgs": "nixpkgs_2"
      },
      "locked": {
        "lastModified": 1672582520,
        "narHash": "sha256-kv3UiJUqMSF1qd3r4OCWomVTHTYjwX/EBRWm8mOSdwg=",
        "owner": "nvim-neorg",
        "repo": "tree-sitter-norg",
        "rev": "d7a466e182a532065a559dbfc7a847271d5e9c29",
        "type": "github"
      },
      "original": {
        "owner": "nvim-neorg",
        "ref": "dev",
        "repo": "tree-sitter-norg",
        "type": "github"
      }
    },
    "norg-meta": {
      "inputs": {
        "flake-compat": "flake-compat_2",
        "flake-utils": "flake-utils_3",
        "nixpkgs": "nixpkgs_3"
      },
      "locked": {
        "lastModified": 1713028366,
        "narHash": "sha256-8qSdwHlfnjFuQF4zNdLtU2/tzDRhDZbo9K54Xxgn5+8=",
        "owner": "nvim-neorg",
        "repo": "tree-sitter-norg-meta",
        "rev": "6f0510cc516a3af3396a682fbd6655486c2c9d2d",
        "type": "github"
      },
      "original": {
        "owner": "nvim-neorg",
        "repo": "tree-sitter-norg-meta",
        "type": "github"
      }
    },
    "plugins-hardtime-nvim": {
      "flake": false,
      "locked": {
        "lastModified": 1748532608,
        "narHash": "sha256-1bUp5YPXJ4Smc2unn7IN5tNv7UVFZvKPcxd5wnDt3Ig=",
        "owner": "m4xshen",
        "repo": "hardtime.nvim",
        "rev": "145b930954a3146cfb5b8a73cdcad42eb7d2740c",
        "type": "github"
      },
      "original": {
        "owner": "m4xshen",
        "repo": "hardtime.nvim",
        "type": "github"
      }
    },
    "plugins-jupytext-nvim": {
      "flake": false,
      "locked": {
        "lastModified": 1747087406,
        "narHash": "sha256-W6fkL1w2dYSjpAYOtBTlYjd2CMYPB596NQzBylIVHrE=",
        "owner": "bkp5190",
        "repo": "jupytext.nvim",
        "rev": "695295069a3aac0cf9a1b768589216c5b837b6f1",
        "type": "github"
      },
      "original": {
        "owner": "bkp5190",
        "ref": "deprecated-healthchecks",
        "repo": "jupytext.nvim",
        "type": "github"
      }
    },
    "plugins-log-highlight-nvim": {
      "flake": false,
      "locked": {
        "lastModified": 1745854920,
        "narHash": "sha256-WsTf0kmwccmZVNpLqEq0SLZ4zb3Sf0OrG4Bzl5h+gug=",
        "owner": "fei6409",
        "repo": "log-highlight.nvim",
        "rev": "ad14bf52ef93d83a625ab22a1ed94405bcacbcf7",
        "type": "github"
      },
      "original": {
        "owner": "fei6409",
        "repo": "log-highlight.nvim",
        "type": "github"
      }
    },
    "plugins-neorg-interim-ls": {
      "flake": false,
      "locked": {
        "lastModified": 1739757865,
        "narHash": "sha256-3+nFHePVPbGtMT8mVsd4DYDoIgyzLhN3RMYe4XXdX+8=",
        "owner": "benlubas",
        "repo": "neorg-interim-ls",
        "rev": "348cd121d8b872248e9b0e48e3611c54dfad83f0",
        "type": "github"
      },
      "original": {
        "owner": "benlubas",
        "repo": "neorg-interim-ls",
        "type": "github"
      }
    },
    "plugins-nix-store-nvim": {
      "flake": false,
      "locked": {
        "lastModified": 1739927138,
        "narHash": "sha256-/rbS47LmWx1Uunuf4kuhYzM/5en1b3vbikAwXr9XLmA=",
        "owner": "wizardlink",
        "repo": "nix-store.nvim",
        "rev": "b026abae4b0c92998b4c9312e8225068b6fb31e5",
        "type": "github"
      },
      "original": {
        "owner": "wizardlink",
        "repo": "nix-store.nvim",
        "type": "github"
      }
    },
    "plugins-roslyn-nvim": {
      "flake": false,
      "locked": {
        "lastModified": 1748282891,
        "narHash": "sha256-wn4nK7KRxDH3qNUO1d1ayTKOnfCpIi7YWTXb/jxywGs=",
        "owner": "seblyng",
        "repo": "roslyn.nvim",
        "rev": "65769488fca061e5663c575c73da277ec1e5abc2",
        "type": "github"
      },
      "original": {
        "owner": "seblyng",
        "repo": "roslyn.nvim",
        "type": "github"
      }
    },
    "plugins-rzls-nvim": {
      "flake": false,
      "locked": {
        "lastModified": 1748076419,
        "narHash": "sha256-ersitb3TUgLXqrqh5Xmy80pZfBMpWEjqrxmw+DTUof0=",
        "owner": "tris203",
        "repo": "rzls.nvim",
        "rev": "27b4c4c3bf35f3d83ccfba8c696c96f7e1d9c154",
        "type": "github"
      },
      "original": {
        "owner": "tris203",
        "repo": "rzls.nvim",
        "type": "github"
      }
    },
    "plugins-venv-selector-nvim": {
      "flake": false,
      "locked": {
        "lastModified": 1732397488,
        "narHash": "sha256-L4L14yq5Ix3w5ty/CImkQXx/CBxwH7jsQhU+dWKndtQ=",
        "owner": "linux-cultist",
        "repo": "venv-selector.nvim",
        "rev": "f212a424fb29949cb5e683928bdd4038bbe0062d",
        "type": "github"
      },
      "original": {
        "owner": "linux-cultist",
        "repo": "venv-selector.nvim",
        "type": "github"
      }
    },
    "root": {
      "inputs": {
        "nixCats": "nixCats",
        "nixpkgs": "nixpkgs_4"
      }
    },
    "systems": {
      "locked": {
        "lastModified": 1681028828,
        "narHash": "sha256-Vy1rq5AaRuLzOxct8nz4T6wlgyUR7zLU309k9mBC768=",
        "owner": "nix-systems",
        "repo": "default",
        "rev": "da67096a3b9bf56a91d16901293e51ba5b49a27e",
        "type": "github"
      },
      "original": {
        "owner": "nix-systems",
        "repo": "default",
        "type": "github"
      }
    }
  },
  "root": "root",
  "version": 7
}


---
./flake.nix
---
{
  description = "A Nix-flake-based C# development environment";

  inputs.nixpkgs.url = "github:nixos/nixpkgs/nixos-unstable";

  inputs.nixCats = {
    url = "github:Hier0nim/nvim";
    inputs.nixpkgs.follows = "nixpkgs";
  };

  outputs =
    {
      self,
      nixpkgs,
      nixCats,
    }:
    let
      supportedSystems = [
        "x86_64-linux"
        "aarch64-linux"
        "x86_64-darwin"
        "aarch64-darwin"
      ];
      forEachSupportedSystem =
        f:
        nixpkgs.lib.genAttrs supportedSystems (
          system:
          f {
            pkgs = import nixpkgs { inherit system; };
          }
        );
    in
    {
      devShells = forEachSupportedSystem (
        { pkgs }:
        {
          default = pkgs.mkShell {
            packages = [
              pkgs.dotnetCorePackages.dotnet_10.sdk
              pkgs.dotnetPackages.Nuget
              pkgs.netcoredbg

              nixCats.packages.x86_64-linux.nvim-dotnet
            ];
          };
        }
      );
    };
}


---
./output.md
---
./LinkedHeap.nuspec
---
<?xml version="1.0"?>
<package >
  <metadata>
    <id>LinkedHeap</id>
    <version>1.0.0</version>
    <authors>Hieronim Daniel, Michał Pawela</authors>
    <requireLicenseAcceptance>false</requireLicenseAcceptance>
    <license type="expression">MIT</license>
    <projectUrl>https://github.com/Hier0nim/LinkedHeap</projectUrl>
    <summary>Pointer-based stack and queue with a custom heap manager in C#.</summary>
    <description>Custom stack and queue implementation using pointer-based lists with a custom heap manager.</description>
    <releaseNotes>Initial release with stack, queue, and custom heap implementation.</releaseNotes>
    <tags>heap stack queue pointer datastructure</tags>
    <dependencies>
      <group targetFramework="net10.0">
        <!-- <dependency id="SomePackage" version="1.2.3" /> -->
        <dependency id="Microsoft.Extensions.DependencyInjection.Abstractions" version="10.0.0-preview.4.25258.110" />
      </group>
    </dependencies>
    <readme>README.md</readme>
    <repository type="git" url="https://github.com/Hier0nim/LinkedHeap" />
  </metadata>
  <files>
    <file src="LinkedHeap/bin/Release/net10.0/LinkedHeap.dll" target="lib/net10.0" />
    <file src="README.md" target="" />
  </files>
</package>


---
./LinkedHeap.slnx
---
﻿<Solution>
  <Configurations>
    <Platform Name="Any CPU" />
    <Platform Name="x64" />
    <Platform Name="x86" />
  </Configurations>
  <Project Path="LinkedHeap/LinkedHeap.csproj" />
  <Project Path="LinkedHeap.Tests/LinkedHeap.Tests.csproj" />
  <Project Path="LinkedHeap.Demo/LinkedHeap.Demo.csproj" />
</Solution>


---
./README.md
---
# LinkedHeap


---
./flake.lock
---
{
  "nodes": {
    "flake-compat": {
      "flake": false,
      "locked": {
        "lastModified": 1641205782,
        "narHash": "sha256-4jY7RCWUoZ9cKD8co0/4tFARpWB+57+r1bLLvXNJliY=",
        "owner": "edolstra",
        "repo": "flake-compat",
        "rev": "b7547d3eed6f32d06102ead8991ec52ab0a4f1a7",
        "type": "github"
      },
      "original": {
        "owner": "edolstra",
        "repo": "flake-compat",
        "type": "github"
      }
    },
    "flake-compat_2": {
      "flake": false,
      "locked": {
        "lastModified": 1641205782,
        "narHash": "sha256-4jY7RCWUoZ9cKD8co0/4tFARpWB+57+r1bLLvXNJliY=",
        "owner": "edolstra",
        "repo": "flake-compat",
        "rev": "b7547d3eed6f32d06102ead8991ec52ab0a4f1a7",
        "type": "github"
      },
      "original": {
        "owner": "edolstra",
        "repo": "flake-compat",
        "type": "github"
      }
    },
    "flake-utils": {
      "inputs": {
        "systems": "systems"
      },
      "locked": {
        "lastModified": 1731533236,
        "narHash": "sha256-l0KFg5HjrsfsO/JpG+r7fRrqm12kzFHyUHqHCVpMMbI=",
        "owner": "numtide",
        "repo": "flake-utils",
        "rev": "11707dc2f618dd54ca8739b309ec4fc024de578b",
        "type": "github"
      },
      "original": {
        "owner": "numtide",
        "repo": "flake-utils",
        "type": "github"
      }
    },
    "flake-utils_2": {
      "locked": {
        "lastModified": 1644229661,
        "narHash": "sha256-1YdnJAsNy69bpcjuoKdOYQX0YxZBiCYZo4Twxerqv7k=",
        "owner": "numtide",
        "repo": "flake-utils",
        "rev": "3cecb5b042f7f209c56ffd8371b2711a290ec797",
        "type": "github"
      },
      "original": {
        "owner": "numtide",
        "repo": "flake-utils",
        "type": "github"
      }
    },
    "flake-utils_3": {
      "locked": {
        "lastModified": 1644229661,
        "narHash": "sha256-1YdnJAsNy69bpcjuoKdOYQX0YxZBiCYZo4Twxerqv7k=",
        "owner": "numtide",
        "repo": "flake-utils",
        "rev": "3cecb5b042f7f209c56ffd8371b2711a290ec797",
        "type": "github"
      },
      "original": {
        "owner": "numtide",
        "repo": "flake-utils",
        "type": "github"
      }
    },
    "neorg": {
      "flake": false,
      "locked": {
        "lastModified": 1747755429,
        "narHash": "sha256-07QhATJIWAXNEN8liiWFWRS/hMs59Xjs4MF2lpKoaOE=",
        "owner": "nvim-neorg",
        "repo": "neorg",
        "rev": "f8c932adf75ba65cd015cdbcf9ed1b96814cf55e",
        "type": "github"
      },
      "original": {
        "owner": "nvim-neorg",
        "repo": "neorg",
        "type": "github"
      }
    },
    "neorg-overlay": {
      "inputs": {
        "flake-utils": "flake-utils",
        "neorg": "neorg",
        "neorg-telescope": "neorg-telescope",
        "nixpkgs": "nixpkgs",
        "norg": "norg",
        "norg-meta": "norg-meta"
      },
      "locked": {
        "lastModified": 1748568195,
        "narHash": "sha256-SI6Jk61VJU0SwysjcMUqHkFUITpfmpgv+VLKpTmcn0s=",
        "owner": "nvim-neorg",
        "repo": "nixpkgs-neorg-overlay",
        "rev": "b33c8336aad2ba353bdd37b6c0bb8f2dfc05d3ee",
        "type": "github"
      },
      "original": {
        "owner": "nvim-neorg",
        "repo": "nixpkgs-neorg-overlay",
        "type": "github"
      }
    },
    "neorg-telescope": {
      "flake": false,
      "locked": {
        "lastModified": 1744866747,
        "narHash": "sha256-tvbskEQ3+uOUlGKdqAFMlbF5Vw0A08XTwuWEs2aP64o=",
        "owner": "nvim-neorg",
        "repo": "neorg-telescope",
        "rev": "7fb6ca6a632c3c095601d379a664c0c1f802dc6c",
        "type": "github"
      },
      "original": {
        "owner": "nvim-neorg",
        "repo": "neorg-telescope",
        "type": "github"
      }
    },
    "nixCats": {
      "inputs": {
        "neorg-overlay": "neorg-overlay",
        "nixCats": "nixCats_2",
        "nixpkgs": [
          "nixpkgs"
        ],
        "plugins-hardtime-nvim": "plugins-hardtime-nvim",
        "plugins-jupytext-nvim": "plugins-jupytext-nvim",
        "plugins-log-highlight-nvim": "plugins-log-highlight-nvim",
        "plugins-neorg-interim-ls": "plugins-neorg-interim-ls",
        "plugins-nix-store-nvim": "plugins-nix-store-nvim",
        "plugins-roslyn-nvim": "plugins-roslyn-nvim",
        "plugins-rzls-nvim": "plugins-rzls-nvim",
        "plugins-venv-selector-nvim": "plugins-venv-selector-nvim"
      },
      "locked": {
        "lastModified": 1748945485,
        "narHash": "sha256-ro+cjcX3yzEd78+2ekKVuyLrNsMWErQ5yFXYQLBFu1A=",
        "owner": "Hier0nim",
        "repo": "nvim",
        "rev": "1368976ecda1b3d087acc92d8426e346cd5d2ff5",
        "type": "github"
      },
      "original": {
        "owner": "Hier0nim",
        "repo": "nvim",
        "type": "github"
      }
    },
    "nixCats_2": {
      "locked": {
        "lastModified": 1748230488,
        "narHash": "sha256-CktYY2rcFPJ3Tbz5H/nDnkhaO18nrLGdWa1mH7V9X5Q=",
        "owner": "BirdeeHub",
        "repo": "nixCats-nvim",
        "rev": "2a2f15a6c085524ac121f5da9a73ee2155c53d70",
        "type": "github"
      },
      "original": {
        "owner": "BirdeeHub",
        "repo": "nixCats-nvim",
        "type": "github"
      }
    },
    "nixpkgs": {
      "locked": {
        "lastModified": 1748506378,
        "narHash": "sha256-oS0Gxh63Df8b8r04lqEYDDLKhHIrVr9/JLOn2bn8JaI=",
        "owner": "NixOS",
        "repo": "nixpkgs",
        "rev": "3866ad91cfc172f08a6839def503d8fc2923c603",
        "type": "github"
      },
      "original": {
        "owner": "NixOS",
        "ref": "nixpkgs-unstable",
        "repo": "nixpkgs",
        "type": "github"
      }
    },
    "nixpkgs_2": {
      "locked": {
        "lastModified": 1644486793,
        "narHash": "sha256-EeijR4guVHgVv+JpOX3cQO+1XdrkJfGmiJ9XVsVU530=",
        "owner": "NixOS",
        "repo": "nixpkgs",
        "rev": "1882c6b7368fd284ad01b0a5b5601ef136321292",
        "type": "github"
      },
      "original": {
        "owner": "NixOS",
        "ref": "nixpkgs-unstable",
        "repo": "nixpkgs",
        "type": "github"
      }
    },
    "nixpkgs_3": {
      "locked": {
        "lastModified": 1644486793,
        "narHash": "sha256-EeijR4guVHgVv+JpOX3cQO+1XdrkJfGmiJ9XVsVU530=",
        "owner": "NixOS",
        "repo": "nixpkgs",
        "rev": "1882c6b7368fd284ad01b0a5b5601ef136321292",
        "type": "github"
      },
      "original": {
        "owner": "NixOS",
        "ref": "nixpkgs-unstable",
        "repo": "nixpkgs",
        "type": "github"
      }
    },
    "nixpkgs_4": {
      "locked": {
        "lastModified": 1748929857,
        "narHash": "sha256-lcZQ8RhsmhsK8u7LIFsJhsLh/pzR9yZ8yqpTzyGdj+Q=",
        "owner": "nixos",
        "repo": "nixpkgs",
        "rev": "c2a03962b8e24e669fb37b7df10e7c79531ff1a4",
        "type": "github"
      },
      "original": {
        "owner": "nixos",
        "ref": "nixos-unstable",
        "repo": "nixpkgs",
        "type": "github"
      }
    },
    "norg": {
      "inputs": {
        "flake-compat": "flake-compat",
        "flake-utils": "flake-utils_2",
        "nixpkgs": "nixpkgs_2"
      },
      "locked": {
        "lastModified": 1672582520,
        "narHash": "sha256-kv3UiJUqMSF1qd3r4OCWomVTHTYjwX/EBRWm8mOSdwg=",
        "owner": "nvim-neorg",
        "repo": "tree-sitter-norg",
        "rev": "d7a466e182a532065a559dbfc7a847271d5e9c29",
        "type": "github"
      },
      "original": {
        "owner": "nvim-neorg",
        "ref": "dev",
        "repo": "tree-sitter-norg",
        "type": "github"
      }
    },
    "norg-meta": {
      "inputs": {
        "flake-compat": "flake-compat_2",
        "flake-utils": "flake-utils_3",
        "nixpkgs": "nixpkgs_3"
      },
      "locked": {
        "lastModified": 1713028366,
        "narHash": "sha256-8qSdwHlfnjFuQF4zNdLtU2/tzDRhDZbo9K54Xxgn5+8=",
        "owner": "nvim-neorg",
        "repo": "tree-sitter-norg-meta",
        "rev": "6f0510cc516a3af3396a682fbd6655486c2c9d2d",
        "type": "github"
      },
      "original": {
        "owner": "nvim-neorg",
        "repo": "tree-sitter-norg-meta",
        "type": "github"
      }
    },
    "plugins-hardtime-nvim": {
      "flake": false,
      "locked": {
        "lastModified": 1748532608,
        "narHash": "sha256-1bUp5YPXJ4Smc2unn7IN5tNv7UVFZvKPcxd5wnDt3Ig=",
        "owner": "m4xshen",
        "repo": "hardtime.nvim",
        "rev": "145b930954a3146cfb5b8a73cdcad42eb7d2740c",
        "type": "github"
      },
      "original": {
        "owner": "m4xshen",
        "repo": "hardtime.nvim",
        "type": "github"
      }
    },
    "plugins-jupytext-nvim": {
      "flake": false,
      "locked": {
        "lastModified": 1747087406,
        "narHash": "sha256-W6fkL1w2dYSjpAYOtBTlYjd2CMYPB596NQzBylIVHrE=",
        "owner": "bkp5190",
        "repo": "jupytext.nvim",
        "rev": "695295069a3aac0cf9a1b768589216c5b837b6f1",
        "type": "github"
      },
      "original": {
        "owner": "bkp5190",
        "ref": "deprecated-healthchecks",
        "repo": "jupytext.nvim",
        "type": "github"
      }
    },
    "plugins-log-highlight-nvim": {
      "flake": false,
      "locked": {
        "lastModified": 1745854920,
        "narHash": "sha256-WsTf0kmwccmZVNpLqEq0SLZ4zb3Sf0OrG4Bzl5h+gug=",
        "owner": "fei6409",
        "repo": "log-highlight.nvim",
        "rev": "ad14bf52ef93d83a625ab22a1ed94405bcacbcf7",
        "type": "github"
      },
      "original": {
        "owner": "fei6409",
        "repo": "log-highlight.nvim",
        "type": "github"
      }
    },
    "plugins-neorg-interim-ls": {
      "flake": false,
      "locked": {
        "lastModified": 1739757865,
        "narHash": "sha256-3+nFHePVPbGtMT8mVsd4DYDoIgyzLhN3RMYe4XXdX+8=",
        "owner": "benlubas",
        "repo": "neorg-interim-ls",
        "rev": "348cd121d8b872248e9b0e48e3611c54dfad83f0",
        "type": "github"
      },
      "original": {
        "owner": "benlubas",
        "repo": "neorg-interim-ls",
        "type": "github"
      }
    },
    "plugins-nix-store-nvim": {
      "flake": false,
      "locked": {
        "lastModified": 1739927138,
        "narHash": "sha256-/rbS47LmWx1Uunuf4kuhYzM/5en1b3vbikAwXr9XLmA=",
        "owner": "wizardlink",
        "repo": "nix-store.nvim",
        "rev": "b026abae4b0c92998b4c9312e8225068b6fb31e5",
        "type": "github"
      },
      "original": {
        "owner": "wizardlink",
        "repo": "nix-store.nvim",
        "type": "github"
      }
    },
    "plugins-roslyn-nvim": {
      "flake": false,
      "locked": {
        "lastModified": 1748282891,
        "narHash": "sha256-wn4nK7KRxDH3qNUO1d1ayTKOnfCpIi7YWTXb/jxywGs=",
        "owner": "seblyng",
        "repo": "roslyn.nvim",
        "rev": "65769488fca061e5663c575c73da277ec1e5abc2",
        "type": "github"
      },
      "original": {
        "owner": "seblyng",
        "repo": "roslyn.nvim",
        "type": "github"
      }
    },
    "plugins-rzls-nvim": {
      "flake": false,
      "locked": {
        "lastModified": 1748076419,
        "narHash": "sha256-ersitb3TUgLXqrqh5Xmy80pZfBMpWEjqrxmw+DTUof0=",
        "owner": "tris203",
        "repo": "rzls.nvim",
        "rev": "27b4c4c3bf35f3d83ccfba8c696c96f7e1d9c154",
        "type": "github"
      },
      "original": {
        "owner": "tris203",
        "repo": "rzls.nvim",
        "type": "github"
      }
    },
    "plugins-venv-selector-nvim": {
      "flake": false,
      "locked": {
        "lastModified": 1732397488,
        "narHash": "sha256-L4L14yq5Ix3w5ty/CImkQXx/CBxwH7jsQhU+dWKndtQ=",
        "owner": "linux-cultist",
        "repo": "venv-selector.nvim",
        "rev": "f212a424fb29949cb5e683928bdd4038bbe0062d",
        "type": "github"
      },
      "original": {
        "owner": "linux-cultist",
        "repo": "venv-selector.nvim",
        "type": "github"
      }
    },
    "root": {
      "inputs": {
        "nixCats": "nixCats",
        "nixpkgs": "nixpkgs_4"
      }
    },
    "systems": {
      "locked": {
        "lastModified": 1681028828,
        "narHash": "sha256-Vy1rq5AaRuLzOxct8nz4T6wlgyUR7zLU309k9mBC768=",
        "owner": "nix-systems",
        "repo": "default",
        "rev": "da67096a3b9bf56a91d16901293e51ba5b49a27e",
        "type": "github"
      },
      "original": {
        "owner": "nix-systems",
        "repo": "default",
        "type": "github"
      }
    }
  },
  "root": "root",
  "version": 7
}


---
./LinkedHeap/CustomHeap.cs
---
using System.Runtime.InteropServices;

namespace LinkedHeap
{
  /// <summary>
  /// A custom heap manager that allocates unmanaged <see cref="HeapNode{T}"/> blocks,
  /// hands out node pointers as <see cref="IntPtr"/>, and tracks free nodes via a pointer chain.
  /// </summary>
  /// <typeparam name="T">A value‐type that is unmanaged.</typeparam>
  public unsafe class CustomHeap<T> : IHeap<T>, IDisposable
      where T : unmanaged
  {
    /// <summary>
    /// All allocated block base addresses.
    /// </summary>
    private readonly List<IntPtr> _blocks = [];

    /// <summary>
    /// Capacity (# nodes) for each block.
    /// </summary>
    private readonly List<int> _blockCapacities = [];

    /// <summary>
    /// Head of the free‐list chain (raw pointer).
    /// </summary>
    private HeapNode<T>* _freeListHead;

    /// <summary>
    /// Initial block size in nodes.
    /// </summary>
    private readonly int _initialCapacity;

    /// <summary>
    /// Next block’s capacity (we double each time).
    /// </summary>
    private int _nextBlockCapacity;

    /// <inheritdoc/>
    public event Action<IntPtr> OnAllocate = delegate { };

    /// <inheritdoc/>
    public event Action<IntPtr> OnFree = delegate { };

    /// <summary>
    /// Creates a new <see cref="CustomHeap{T}"/> with an initial capacity.
    /// </summary>
    /// <param name="initialCapacity">
    /// Number of nodes to allocate in the first block. Must be &gt; 0.
    /// </param>
    public CustomHeap(int initialCapacity = 1)
    {
      if (initialCapacity <= 0)
        throw new ArgumentOutOfRangeException(nameof(initialCapacity), "Capacity must be positive.");

      _initialCapacity = initialCapacity;
      _nextBlockCapacity = initialCapacity;
      AllocateBlock(_initialCapacity);
    }

    /// <inheritdoc/>
    public IntPtr Allocate(T value)
    {
      if (_freeListHead == null)
      {
        // No free nodes remain: allocate a new block (double size)
        AllocateBlock(_nextBlockCapacity);
        _nextBlockCapacity *= 2;
      }

      // Pop one node from the free‐list
      HeapNode<T>* node = _freeListHead;
      _freeListHead = node->Next;

      // Initialize the node
      node->Value = value;
      node->Next = null;
      node->InUse = 1;

      nint ptr = new(node);
      OnAllocate(ptr);
      return ptr;
    }

    /// <inheritdoc/>
    public void Free(IntPtr nodePtr)
    {
      if (nodePtr == IntPtr.Zero)
      {
        throw new InvalidOperationException("Cannot free a null pointer.");
      }

      var node = (HeapNode<T>*)nodePtr;
      if (node->InUse == 0)
      {
        throw new InvalidOperationException("Node is already freed.");
      }

      node->InUse = 0;
      node->Next = _freeListHead;
      _freeListHead = node;

      OnFree(nodePtr);
    }

    /// <inheritdoc/>
    public IEnumerable<IntPtr> GetAllNodes()
    {
      // Build a list of every node pointer in every block, then return it.
      var result = new List<IntPtr>();
      for (int blockIndex = 0; blockIndex < _blocks.Count; blockIndex++)
      {
        var basePtr = (HeapNode<T>*)_blocks[blockIndex];
        int capacity = _blockCapacities[blockIndex];

        for (int i = 0; i < capacity; i++)
        {
          result.Add(new IntPtr(&basePtr[i]));
        }
      }

      return result;
    }

    /// <summary>
    /// Allocates a new unmanaged block of <paramref name="capacity"/> <see cref="HeapNode{T}"/> structs,
    /// initializes its free‐list chain, and prepends it to the existing free list.
    /// </summary>
    /// <param name="capacity">Number of nodes to allocate in this block.</param>
    private void AllocateBlock(int capacity)
    {
      int nodeSize = sizeof(HeapNode<T>);
      nint rawBlock = Marshal.AllocHGlobal(nodeSize * capacity);
      _blocks.Add(rawBlock);
      _blockCapacities.Add(capacity);

      var firstNode = (HeapNode<T>*)rawBlock;
      // Link all nodes in this block into a local free‐list
      for (int i = 0; i < capacity; i++)
      {
        HeapNode<T>* current = &firstNode[i];
        current->InUse = 0;
        current->Next = (i < capacity - 1) ? &firstNode[i + 1] : null;
      }

      // If there was already a free list, link the new block’s last node to it
      if (_freeListHead != null)
      {
        HeapNode<T>* lastInNewBlock = &firstNode[capacity - 1];
        lastInNewBlock->Next = _freeListHead;
      }

      // Now point the free‐list head to this block’s first node
      _freeListHead = firstNode;
    }

    /// <summary>
    /// Frees all unmanaged memory blocks.
    /// </summary>
    public void Dispose()
    {
      foreach (nint block in _blocks)
      {
        Marshal.FreeHGlobal(block);
      }

      _blocks.Clear();
      _blockCapacities.Clear();
      _freeListHead = null;
      GC.SuppressFinalize(this);
    }
  }
}


---
./LinkedHeap/HeapNode.cs
---
using System.Runtime.InteropServices;

namespace LinkedHeap
{
  /// <summary>
  /// Represents a single node in the custom unmanaged heap.
  /// </summary>
  /// <typeparam name="T">A value‐type that is unmanaged.</typeparam>
  [StructLayout(LayoutKind.Sequential)]
  public unsafe struct HeapNode<T> where T : unmanaged
  {
    /// <summary>
    /// The user’s payload. Stored in unmanaged memory.
    /// </summary>
    public T Value;

    /// <summary>
    /// Pointer to the next node in either:
    ///  • the free list (if <see cref="InUse"/> is 0), or
    ///  • a stack/queue link (if <see cref="InUse"/> is 1).
    /// </summary>
    public HeapNode<T>* Next;

    /// <summary>
    /// 1 if this node is currently allocated/in use; 0 if it is free.
    /// </summary>
    public byte InUse;
  }
}



---
./LinkedHeap/HeapQueue.cs
---
namespace LinkedHeap
{
  /// <summary>
  /// A First-In‐First-Out queue backed by <see cref="IHeap{T}"/>,
  /// using real <see cref="HeapNode{T}"/> pointers internally.
  /// Exposes node pointers as <see cref="IntPtr"/> for public enumeration.
  /// </summary>
  /// <typeparam name="T">A value‐type that is unmanaged.</typeparam>
  /// <remarks>
  /// Initializes a new instance of <see cref="HeapQueue{T}"/> using the given unmanaged heap.
  /// </remarks>
  /// <param name="heap">An <see cref="IHeap{T}"/> to allocate/free nodes.</param>
  public unsafe class HeapQueue<T>(IHeap<T> heap) : IQueue<T> where T : unmanaged
  {
    /// <summary>
    /// The underlying unmanaged heap used to allocate and free nodes.
    /// </summary>
    private readonly IHeap<T> _heap = heap ?? throw new ArgumentNullException(nameof(heap));

    /// <summary>
    /// Pointer to the front node of the queue; null if the queue is empty.
    /// </summary>
    private HeapNode<T>* _head = null;

    /// <summary>
    /// Pointer to the back node of the queue; null if the queue is empty.
    /// </summary>
    private HeapNode<T>* _tail = null;

    /// <inheritdoc/>
    public event Action OnChanged = delegate { };

    /// <inheritdoc/>
    public bool IsEmpty => _head == null;

    /// <inheritdoc/>
    public void Enqueue(T value)
    {
      nint ptr = _heap.Allocate(value);
      var node = (HeapNode<T>*)ptr;

      if (_head == null)
      {
        // Empty queue
        _head = node;
        _tail = node;
      }
      else
      {
        _tail->Next = node;
        _tail = node;
      }

      OnChanged();
    }

    /// <inheritdoc/>
    public T Dequeue()
    {
      if (_head == null)
        throw new InvalidOperationException("Queue is empty.");

      HeapNode<T>* node = _head;
      T result = node->Value;
      _head = node->Next;

      if (_head == null)
        _tail = null;

      _heap.Free(new IntPtr(node));
      OnChanged();
      return result;
    }

    /// <inheritdoc/>
    public T Peek()
    {
      if (_head == null)
        throw new InvalidOperationException("Queue is empty.");

      return _head->Value;
    }

    /// <inheritdoc/>
    public IEnumerable<IntPtr> GetNodePointers()
    {
      // Build a list of pointers in FIFO order, then return it
      var result = new List<IntPtr>();
      HeapNode<T>* cursor = _head;
      while (cursor != null)
      {
        result.Add(new IntPtr(cursor));
        cursor = cursor->Next;
      }
      return result;
    }
  }
}


---
./LinkedHeap/HeapStack.cs
---
namespace LinkedHeap
{
  /// <summary>
  /// A Last-In‐First-Out stack backed by <see cref="IHeap{T}"/>,
  /// using real <see cref="HeapNode{T}"/> pointers for linkage internally.
  /// Exposes node pointers as <see cref="IntPtr"/> for public enumeration.
  /// </summary>
  /// <typeparam name="T">A value‐type that is unmanaged.</typeparam>
  /// <remarks>
  /// Initializes a new instance of <see cref="HeapStack{T}"/> using the given unmanaged heap.
  /// </remarks>
  /// <param name="heap">An <see cref="IHeap{T}"/> to allocate/free nodes.</param>
  public unsafe class HeapStack<T>(IHeap<T> heap) : IStack<T> where T : unmanaged
  {
    /// <summary>
    /// The underlying unmanaged heap used to allocate and free nodes.
    /// </summary>
    private readonly IHeap<T> _heap = heap ?? throw new ArgumentNullException(nameof(heap));

    /// <summary>
    /// Pointer to the current top node of the stack; null if the stack is empty.
    /// </summary>
    private HeapNode<T>* _top = null;

    /// <inheritdoc/>
    public event Action OnChanged = delegate { };

    /// <inheritdoc/>
    public bool IsEmpty => _top == null;

    /// <inheritdoc/>
    public void Push(T value)
    {
      nint ptr = _heap.Allocate(value);
      var node = (HeapNode<T>*)ptr;

      node->Next = _top;
      _top = node;

      OnChanged();
    }

    /// <inheritdoc/>
    public T Pop()
    {
      if (_top == null)
        throw new InvalidOperationException("Stack is empty.");

      HeapNode<T>* node = _top;
      T result = node->Value;
      _top = node->Next;

      _heap.Free(new IntPtr(node));
      OnChanged();
      return result;
    }

    /// <inheritdoc/>
    public T Peek()
    {
      if (_top == null)
        throw new InvalidOperationException("Stack is empty.");

      return _top->Value;
    }

    /// <inheritdoc/>
    public IEnumerable<IntPtr> GetNodePointers()
    {
      // Build a list of pointers in LIFO order, then return it
      var result = new List<IntPtr>();
      HeapNode<T>* cursor = _top;
      while (cursor != null)
      {
        result.Add(new IntPtr(cursor));
        cursor = cursor->Next;
      }
      return result;
    }
  }
}


---
./LinkedHeap/IHeap.cs
---
namespace LinkedHeap
{
  /// <summary>
  /// Manages a pool of unmanaged <see cref="HeapNode{T}"/> structs in native memory,
  /// allowing allocation and deallocation via raw pointers (exposed as <see cref="IntPtr"/>).
  /// </summary>
  /// <typeparam name="T">A value‐type that is unmanaged.</typeparam>
  public unsafe interface IHeap<T> where T : unmanaged
  {
    /// <summary>
    /// Fires when a new <see cref="HeapNode{T}"/> is allocated.
    /// The argument is the pointer (as <see cref="IntPtr"/>) to the newly‐allocated node.
    /// </summary>
    event Action<IntPtr> OnAllocate;

    /// <summary>
    /// Fires when a <see cref="HeapNode{T}"/> is freed.
    /// The argument is the pointer (as <see cref="IntPtr"/>) to the freed node.
    /// </summary>
    event Action<IntPtr> OnFree;

    /// <summary>
    /// Allocates a node containing <paramref name="value"/> and returns its pointer as <see cref="IntPtr"/>.
    /// </summary>
    /// <param name="value">The payload to store in the node.</param>
    /// <returns>An <see cref="IntPtr"/> pointing to the newly‐allocated <see cref="HeapNode{T}"/>.</returns>
    IntPtr Allocate(T value);

    /// <summary>
    /// Frees the node at the given <paramref name="nodePtr"/> (which must have been previously allocated),
    /// returning it to the free list.
    /// </summary>
    /// <param name="nodePtr">Pointer (as <see cref="IntPtr"/>) to the node being freed.</param>
    void Free(IntPtr nodePtr);

    /// <summary>
    /// Enumerates every node in every allocated block (both free and in‐use),
    /// returning each pointer as <see cref="IntPtr"/> so that callers can inspect each <see cref="HeapNode{T}"/>.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{IntPtr}"/> of raw node pointers.</returns>
    IEnumerable<IntPtr> GetAllNodes();
  }
}


---
./LinkedHeap/IQueue.cs
---
namespace LinkedHeap
{
  /// <summary>
  /// A queue of <see cref="HeapNode{T}"/> pointers built on an <see cref="IHeap{T}"/>.
  /// All pointer manipulations are done in unsafe code (FIFO).
  /// Exposes node pointers as <see cref="IntPtr"/> for public APIs.
  /// </summary>
  /// <typeparam name="T">A value‐type that is unmanaged.</typeparam>
  public unsafe interface IQueue<T> where T : unmanaged
  {
    /// <summary>
    /// Fires whenever an <see cref="Enqueue"/> or <see cref="Dequeue"/> changes the queue.
    /// </summary>
    event Action OnChanged;

    /// <summary>
    /// Returns <c>true</c> if the queue is empty.
    /// </summary>
    bool IsEmpty { get; }

    /// <summary>
    /// Enqueues a new <paramref name="value"/> into the queue.
    /// Allocates a fresh <see cref="HeapNode{T}"/> from the underlying heap.
    /// </summary>
    /// <param name="value">Value to enqueue.</param>
    void Enqueue(T value);

    /// <summary>
    /// Dequeues the front node, returns its value, and frees that node back to the heap.
    /// </summary>
    /// <returns>The <typeparamref name="T"/> that was stored in the front node.</returns>
    T Dequeue();

    /// <summary>
    /// Returns the <typeparamref name="T"/> stored at the queue’s head without removing it.
    /// </summary>
    /// <returns>The front value.</returns>
    T Peek();

    /// <summary>
    /// Enumerates all allocated node pointers (as <see cref="IntPtr"/>) in FIFO order,
    /// from head to tail.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{IntPtr}"/> of node pointers from head to tail.</returns>
    IEnumerable<IntPtr> GetNodePointers();
  }
}


---
./LinkedHeap/IStack.cs
---
namespace LinkedHeap
{
  /// <summary>
  /// A stack of <see cref="HeapNode{T}"/> pointers built on an <see cref="IHeap{T}"/>.
  /// All pointer manipulations are performed in unsafe code (LIFO).
  /// Exposes node pointers as <see cref="IntPtr"/> for public APIs.
  /// </summary>
  /// <typeparam name="T">A value‐type that is unmanaged.</typeparam>
  public unsafe interface IStack<T> where T : unmanaged
  {
    /// <summary>
    /// Fires whenever the stack’s top changes (via <see cref="Push"/> or <see cref="Pop"/>).
    /// </summary>
    event Action OnChanged;

    /// <summary>
    /// Returns <c>true</c> if the stack contains no elements.
    /// </summary>
    bool IsEmpty { get; }

    /// <summary>
    /// Pushes a new <paramref name="value"/> onto the top of the stack.
    /// </summary>
    /// <param name="value">Value to store in a freshly allocated node.</param>
    void Push(T value);

    /// <summary>
    /// Pops the top element off the stack and returns its value.
    /// Frees that node back into the <see cref="IHeap{T}"/>.
    /// </summary>
    /// <returns>The <typeparamref name="T"/> stored at the former top node.</returns>
    T Pop();

    /// <summary>
    /// Returns the value stored at the current top without removing it.
    /// </summary>
    /// <returns>The <typeparamref name="T"/> at the top.</returns>
    T Peek();

    /// <summary>
    /// Enumerates all allocated node pointers (as <see cref="IntPtr"/>) in LIFO order,
    /// starting from the current top down to the bottom.
    /// </summary>
    /// <returns>An <see cref="IEnumerable{IntPtr}"/> of pointers from top to bottom.</returns>
    IEnumerable<IntPtr> GetNodePointers();
  }
}


---
./LinkedHeap/LinkedHeap.csproj
---
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
    <WarningsAsErrors>Nullable</WarningsAsErrors>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
    <GeneratePackageOnBuild>true</GeneratePackageOnBuild>
    <GenerateAssemblyInfo>false</GenerateAssemblyInfo>
    <Authors>Hieronim Daniel, Michał Pawela</Authors>
    <Description>
      A C# library providing a custom unmanaged‐memory heap,
      plus unsafe stack/queue implementations with real pointers.
    </Description>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.Extensions.DependencyInjection.Abstractions" Version="10.0.0-preview.4.25258.110" />
  </ItemGroup>

</Project>


---
./LinkedHeap/LinkedHeapService.cs
---
namespace LinkedHeap
{
  /// <summary>
  /// Wraps one <see cref="CustomHeap{T}"/>, one <see cref="HeapStack{T}"/>,
  /// and one <see cref="HeapQueue{T}"/> into a single injectable service.
  /// </summary>
  /// <typeparam name="T">A value‐type that is unmanaged.</typeparam>
  public sealed class LinkedHeapService<T> : IDisposable
      where T : unmanaged
  {
    /// <summary>
    /// The unmanaged heap instance.
    /// </summary>
    public IHeap<T> Heap { get; }

    /// <summary>
    /// The stack backed by the same unmanaged heap.
    /// </summary>
    public IStack<T> Stack { get; }

    /// <summary>
    /// The queue backed by the same unmanaged heap.
    /// </summary>
    public IQueue<T> Queue { get; }

    /// <summary>
    /// Creates a new <see cref="LinkedHeapService{T}"/> with:
    ///   - <see cref="CustomHeap{T}"/> as the heap,
    ///   - <see cref="HeapStack{T}"/> for the stack,
    ///   - <see cref="HeapQueue{T}"/> for the queue.
    /// </summary>
    public LinkedHeapService()
    {
      var customHeap = new CustomHeap<T>();
      Heap = customHeap;
      Stack = new HeapStack<T>(customHeap);
      Queue = new HeapQueue<T>(customHeap);
    }

    /// <summary>
    /// Disposes the underlying <see cref="CustomHeap{T}"/>.
    /// </summary>
    public void Dispose()
    {
      if (Heap is IDisposable d)
      {
        d.Dispose();
      }
    }
  }
}


---
./LinkedHeap/LinkedHeapServiceCollectionExtensions.cs
---
using Microsoft.Extensions.DependencyInjection;

namespace LinkedHeap
{
  /// <summary>
  /// Extension methods for <see cref="IServiceCollection"/> to register LinkedHeap services.
  /// </summary>
  public static class LinkedHeapServiceCollectionExtensions
  {
    /// <summary>
    /// Registers <see cref="LinkedHeapService{T}"/> (heap, stack, queue) as singletons
    /// in the service collection. Also maps <see cref="IHeap{T}"/>,
    /// <see cref="IStack{T}"/>, and <see cref="IQueue{T}"/> to those instances.
    /// </summary>
    /// <typeparam name="T">A value‐type that is unmanaged.</typeparam>
    /// <param name="services">The <see cref="IServiceCollection"/> to extend.</param>
    /// <returns>The same <see cref="IServiceCollection"/>, for chaining.</returns>
    public static IServiceCollection AddLinkedHeapServices<T>(this IServiceCollection services)
        where T : unmanaged
    {
      services.AddSingleton<LinkedHeapService<T>>();
      services.AddSingleton(sp => sp.GetRequiredService<LinkedHeapService<T>>().Heap);
      services.AddSingleton(sp => sp.GetRequiredService<LinkedHeapService<T>>().Stack);
      services.AddSingleton(sp => sp.GetRequiredService<LinkedHeapService<T>>().Queue);

      return services;
    }
  }
}


---
./LinkedHeap.Tests/CustomHeapTests.cs
---
namespace LinkedHeap.Tests
{
  /// <summary>
  /// Unit tests for <see cref="CustomHeap{T}"/> to verify allocation, freeing,
  /// expansion behavior, and event firing.
  /// </summary>
  [TestFixture]
  public unsafe class CustomHeapTests
  {
    /// <summary>
    /// The <see cref="CustomHeap{T}"/> we are testing.
    /// </summary>
    private CustomHeap<int>? _heap;

    /// <summary>
    /// Sets up a new <see cref="CustomHeap{T}"/> with small initial capacity before each test.
    /// </summary>
    [SetUp]
    public void Setup()
    {
      _heap = new CustomHeap<int>(initialCapacity: 2);
    }

    /// <summary>
    /// Disposes the heap after each test to free unmanaged memory.
    /// </summary>
    [TearDown]
    public void Teardown()
    {
      _heap?.Dispose();
      _heap = null;
    }

    /// <summary>
    /// Verifies that Allocate returns distinct non-zero pointers, marks them in-use,
    /// and fires OnAllocate exactly once per call.
    /// </summary>
    [Test]
    public void Allocate_ShouldReturnDistinctPointers_AndMarkNodesInUse()
    {
      var allocated = new List<IntPtr>();
      _heap!.OnAllocate += ptr => allocated.Add(ptr);

      // Allocate two nodes (initial capacity = 2)
      IntPtr ptr1 = _heap.Allocate(10);
      IntPtr ptr2 = _heap.Allocate(20);

      Assert.That(ptr1, Is.Not.EqualTo(IntPtr.Zero), "First allocation should not return IntPtr.Zero.");
      Assert.That(ptr2, Is.Not.EqualTo(IntPtr.Zero), "Second allocation should not return IntPtr.Zero.");
      Assert.That(ptr1, Is.Not.EqualTo(ptr2), "Two allocations should return distinct pointers.");

      Assert.That(allocated.Count, Is.EqualTo(2), "OnAllocate should fire exactly twice.");
      Assert.That(allocated, Has.Member(ptr1));
      Assert.That(allocated, Has.Member(ptr2));

      // Check node fields
      Assert.That(((HeapNode<int>*)ptr1)->Value, Is.EqualTo(10));
      Assert.That(((HeapNode<int>*)ptr2)->Value, Is.EqualTo(20));
      Assert.That(((HeapNode<int>*)ptr1)->InUse, Is.EqualTo(1), "Node must be marked InUse=1 after allocation.");
      Assert.That(((HeapNode<int>*)ptr2)->InUse, Is.EqualTo(1), "Node must be marked InUse=1 after allocation.");
    }

    /// <summary>
    /// Verifies that Free returns the node to the free list, fires OnFree,
    /// and that subsequent Allocate reuses the freed pointer.
    /// </summary>
    [Test]
    public void Free_ShouldReturnNodeToFreeList_AndFireOnFree()
    {
      var freed = new List<IntPtr>();
      _heap!.OnFree += ptr => freed.Add(ptr);

      IntPtr ptr = _heap.Allocate(42);
      _heap.Free(ptr);

      Assert.That(freed.Count, Is.EqualTo(1), "OnFree should fire exactly once.");
      Assert.That(freed[0], Is.EqualTo(ptr), "Freed pointer should match the one returned.");

      // After free, InUse should be 0
      Assert.That(((HeapNode<int>*)ptr)->InUse, Is.EqualTo(0), "Node should be marked InUse=0 after freeing.");

      // Allocating again should reuse that pointer
      IntPtr ptr2 = _heap.Allocate(99);
      Assert.That(ptr2, Is.EqualTo(ptr), "Freed node should be reused on next Allocate.");
    }

    /// <summary>
    /// Verifies that freeing <see cref="IntPtr.Zero"/> throws <see cref="InvalidOperationException"/>.
    /// </summary>
    [Test]
    public void Free_NullPointer_ShouldThrowInvalidOperationException()
    {
      Assert.That(() => _heap!.Free(IntPtr.Zero),
                  Throws.InvalidOperationException,
                  "Freeing IntPtr.Zero should throw InvalidOperationException.");
    }

    /// <summary>
    /// Verifies that double freeing the same pointer throws <see cref="InvalidOperationException"/>.
    /// </summary>
    [Test]
    public void Free_DoubleFree_ShouldThrowInvalidOperationException()
    {
      IntPtr ptr = _heap!.Allocate(5);
      _heap.Free(ptr);
      Assert.That(() => _heap.Free(ptr),
                  Throws.InvalidOperationException,
                  "Double freeing the same pointer should throw InvalidOperationException.");
    }

    /// <summary>
    /// Verifies that <see cref="CustomHeap{T}.GetAllNodes"/> returns exactly the correct number of pointers
    /// before and after expansion.
    /// </summary>
    [Test]
    public void GetAllNodes_ShouldReturnAllPointersAcrossBlocks()
    {
      // initialCapacity = 2, so first block has 2 nodes
      var allBefore = _heap!.GetAllNodes().ToList();
      Assert.That(allBefore.Count, Is.EqualTo(2), "Initial GetAllNodes should return exactly initialCapacity pointers.");

      // Allocate both nodes to exhaust the free list
      IntPtr a1 = _heap.Allocate(1);
      IntPtr a2 = _heap.Allocate(2);

      // Now free list is empty, next Allocate will cause expansion
      IntPtr a3 = _heap.Allocate(3); // triggers expansion to 4 total

      var allAfter = _heap.GetAllNodes().ToList();
      Assert.That(allAfter.Count, Is.EqualTo(4), "After expansion, GetAllNodes should return total number of nodes across both blocks.");
      Assert.That(allAfter.Distinct().Count(), Is.EqualTo(4), "GetAllNodes should return distinct pointers.");
    }

    /// <summary>
    /// Verifies that Allocate automatically expands the heap when the free list is empty.
    /// </summary>
    [Test]
    public void Allocate_ShouldAutomaticallyExpand_WhenFreeListEmpty()
    {
      // initial capacity = 2
      IntPtr p1 = _heap!.Allocate(100);
      IntPtr p2 = _heap.Allocate(200);
      // Now free list is empty; next allocation triggers expansion
      IntPtr p3 = _heap.Allocate(300);

      var all = _heap.GetAllNodes().ToList();
      Assert.That(all.Count, Is.EqualTo(4), "After expansion, total node count should be doubled to 4.");
      Assert.That(all, Has.Member(p3), "p3 should be among all nodes after expansion.");
    }
  }
}


---
./LinkedHeap.Tests/GlobalUsings.cs
---
global using NUnit.Framework;

---
./LinkedHeap.Tests/HeapQueueTests.cs
---
namespace LinkedHeap.Tests
{
  /// <summary>
  /// Unit tests for <see cref="HeapQueue{T}"/> to verify enqueue, dequeue, peek, order,
  /// event firing, and reuse of heap nodes.
  /// </summary>
  [TestFixture]
  public unsafe class HeapQueueTests
  {
    /// <summary>
    /// The <see cref="CustomHeap{T}"/>.
    /// </summary>
    private CustomHeap<int>? _heap;

    /// <summary>
    /// The <see cref="HeapQueue{T}"/> we are testing.
    /// </summary>
    private HeapQueue<int>? _queue;

    /// <summary>
    /// Sets up a new heap and queue before each test.
    /// </summary>
    [SetUp]
    public void Setup()
    {
      _heap = new CustomHeap<int>(initialCapacity: 4);
      _queue = new HeapQueue<int>(_heap);
    }

    /// <summary>
    /// Disposes the heap and clears references after each test.
    /// </summary>
    [TearDown]
    public void Teardown()
    {
      _queue = null;
      _heap?.Dispose();
      _heap = null;
    }

    /// <summary>
    /// Verifies that Enqueue and Dequeue respect FIFO order, Peek returns the correct element,
    /// and IsEmpty toggles appropriately.
    /// </summary>
    [Test]
    public void Enqueue_Dequeue_ShouldRespectFIFOOrder()
    {
      _queue!.Enqueue(7);
      _queue.Enqueue(14);
      _queue.Enqueue(21);

      Assert.That(_queue.IsEmpty, Is.False, "Queue should not be empty after enqueues.");
      Assert.That(_queue.Peek(), Is.EqualTo(7), "Peek should return first enqueued value (7).");

      int dequeued1 = _queue.Dequeue();
      Assert.That(dequeued1, Is.EqualTo(7), "First Dequeue should return 7.");
      Assert.That(_queue.Peek(), Is.EqualTo(14), "After one dequeue, Peek should return 14.");

      int dequeued2 = _queue.Dequeue();
      Assert.That(dequeued2, Is.EqualTo(14), "Second Dequeue should return 14.");

      int dequeued3 = _queue.Dequeue();
      Assert.That(dequeued3, Is.EqualTo(21), "Third Dequeue should return 21.");

      Assert.That(_queue.IsEmpty, Is.True, "Queue should be empty after dequeuing all elements.");
    }

    /// <summary>
    /// Verifies that dequeuing an empty queue throws <see cref="InvalidOperationException"/>.
    /// </summary>
    [Test]
    public void Dequeue_EmptyQueue_ShouldThrowInvalidOperationException()
    {
      Assert.That(_queue!.IsEmpty, Is.True, "Queue should start empty.");
      Assert.That(() => _queue.Dequeue(),
                  Throws.InvalidOperationException,
                  "Dequeuing an empty queue should throw InvalidOperationException.");
    }

    /// <summary>
    /// Verifies that peeking an empty queue throws <see cref="InvalidOperationException"/>.
    /// </summary>
    [Test]
    public void Peek_EmptyQueue_ShouldThrowInvalidOperationException()
    {
      Assert.That(() => _queue!.Peek(),
                  Throws.InvalidOperationException,
                  "Peeking an empty queue should throw InvalidOperationException.");
    }

    /// <summary>
    /// Verifies that <see cref="HeapQueue{T}.GetNodePointers"/> returns pointers
    /// in correct FIFO sequence corresponding to values.
    /// </summary>
    [Test]
    public void GetNodePointers_ShouldReturnCorrectPointerSequence()
    {
      _queue!.Enqueue(100);
      _queue.Enqueue(200);
      _queue.Enqueue(300);

      var pointers = _queue.GetNodePointers().ToList();
      Assert.That(pointers.Count, Is.EqualTo(3), "Should have 3 node pointers.");

      var values = pointers.Select(ptr => ((HeapNode<int>*)ptr)->Value).ToList();
      Assert.That(values, Is.EqualTo(new[] { 100, 200, 300 }),
                  "Pointer sequence should correspond to values [100,200,300].");
    }

    /// <summary>
    /// Verifies that <see cref="HeapQueue{T}.OnChanged"/> fires once per Enqueue or Dequeue.
    /// </summary>
    [Test]
    public void OnChanged_EventFires_OnEnqueueAndDequeue()
    {
      int changedCount = 0;
      _queue!.OnChanged += () => changedCount++;

      _queue.Enqueue(1);
      _queue.Enqueue(2);
      Assert.That(changedCount, Is.EqualTo(2), "OnChanged should fire for each Enqueue.");

      _queue.Dequeue();
      Assert.That(changedCount, Is.EqualTo(3), "OnChanged should fire for Dequeue as well.");
    }

    /// <summary>
    /// Verifies that enqueuing and dequeuing repeatedly reuses the same heap nodes.
    /// </summary>
    [Test]
    public void EnqueuingAndDequeuingReusesHeapNodes()
    {
      for (int i = 0; i < 5; i++)
      {
        _queue!.Enqueue(i);
      }

      var pointersBefore = _queue!.GetNodePointers().ToList();
      for (int i = 0; i < 5; i++)
      {
        _queue.Dequeue();
      }

      // Now free list contains those nodes; enqueue again should reuse pointers
      _queue.Enqueue(999);
      nint newPtr = _queue.GetNodePointers().First();

      Assert.That(pointersBefore, Does.Contain(newPtr),
                  "After dequeuing, enqueuing should reuse one of the previously used nodes.");
    }
  }
}


---
./LinkedHeap.Tests/HeapStackTests.cs
---
namespace LinkedHeap.Tests
{
  /// <summary>
  /// Unit tests for <see cref="HeapStack{T}"/> to verify push, pop, peek, order,
  /// event firing, and reuse of heap nodes.
  /// </summary>
  [TestFixture]
  public unsafe class HeapStackTests
  {
    /// <summary>
    /// The <see cref="CustomHeap{T}"/>.
    /// </summary>
    private CustomHeap<int>? _heap;

    /// <summary>
    /// The <see cref="HeapStack{T}"/> we are testing.
    /// </summary>
    private HeapStack<int>? _stack;

    /// <summary>
    /// Sets up a new heap and stack before each test.
    /// </summary>
    [SetUp]
    public void Setup()
    {
      _heap = new CustomHeap<int>(initialCapacity: 4);
      _stack = new HeapStack<int>(_heap);
    }

    /// <summary>
    /// Disposes the heap and clears references after each test.
    /// </summary>
    [TearDown]
    public void Teardown()
    {
      _stack = null;
      _heap?.Dispose();
      _heap = null;
    }

    /// <summary>
    /// Verifies that Push and Pop respect LIFO order, Peek returns the correct element,
    /// and IsEmpty toggles appropriately.
    /// </summary>
    [Test]
    public void Push_Pop_ShouldRespectLIFOOrder()
    {
      _stack!.Push(10);
      _stack.Push(20);
      _stack.Push(30);

      Assert.That(_stack.IsEmpty, Is.False, "Stack should not be empty after pushes.");
      Assert.That(_stack.Peek(), Is.EqualTo(30), "Peek should return last pushed value.");

      int popped1 = _stack.Pop();
      Assert.That(popped1, Is.EqualTo(30), "First Pop should return 30.");
      Assert.That(_stack.Peek(), Is.EqualTo(20), "After popping, Peek should return next element (20).");

      int popped2 = _stack.Pop();
      Assert.That(popped2, Is.EqualTo(20), "Second Pop should return 20.");

      int popped3 = _stack.Pop();
      Assert.That(popped3, Is.EqualTo(10), "Third Pop should return 10.");

      Assert.That(_stack.IsEmpty, Is.True, "Stack should be empty after popping all elements.");
    }

    /// <summary>
    /// Verifies that popping an empty stack throws <see cref="InvalidOperationException"/>.
    /// </summary>
    [Test]
    public void Pop_EmptyStack_ShouldThrowInvalidOperationException()
    {
      Assert.That(_stack!.IsEmpty, Is.True, "Stack should start empty.");
      Assert.That(() => _stack.Pop(),
                  Throws.InvalidOperationException,
                  "Popping an empty stack should throw InvalidOperationException.");
    }

    /// <summary>
    /// Verifies that peeking an empty stack throws <see cref="InvalidOperationException"/>.
    /// </summary>
    [Test]
    public void Peek_EmptyStack_ShouldThrowInvalidOperationException()
    {
      Assert.That(() => _stack!.Peek(),
                  Throws.InvalidOperationException,
                  "Peeking an empty stack should throw InvalidOperationException.");
    }

    /// <summary>
    /// Verifies that <see cref="HeapStack{T}.GetNodePointers"/> returns pointers
    /// in correct LIFO sequence corresponding to values.
    /// </summary>
    [Test]
    public void GetNodePointers_ShouldReturnCorrectPointerSequence()
    {
      _stack!.Push(1);
      _stack.Push(2);
      _stack.Push(3);

      var pointers = _stack.GetNodePointers().ToList();
      Assert.That(pointers.Count, Is.EqualTo(3), "Should have 3 node pointers.");

      var values = pointers.Select(ptr => ((HeapNode<int>*)ptr)->Value).ToList();
      Assert.That(values, Is.EqualTo(new[] { 3, 2, 1 }), "Pointer sequence should correspond to values [3,2,1].");
    }

    /// <summary>
    /// Verifies that <see cref="HeapStack{T}.OnChanged"/> fires once per Push or Pop.
    /// </summary>
    [Test]
    public void OnChanged_EventFires_OnPushAndPop()
    {
      int changedCount = 0;
      _stack!.OnChanged += () => changedCount++;

      _stack.Push(5);
      _stack.Push(6);
      Assert.That(changedCount, Is.EqualTo(2), "OnChanged should fire for each Push.");

      _stack.Pop();
      Assert.That(changedCount, Is.EqualTo(3), "OnChanged should fire for Pop as well.");
    }

    /// <summary>
    /// Verifies that pushing and popping repeatedly reuses the same heap nodes.
    /// </summary>
    [Test]
    public void PushingAndPoppingReusesHeapNodes()
    {
      for (int i = 0; i < 5; i++)
      {
        _stack!.Push(i);
      }

      var pointersBefore = _stack!.GetNodePointers().ToList();
      for (int i = 0; i < 5; i++)
      {
        _stack.Pop();
      }

      // Now free list should contain those 5 nodes; pushing again should reuse pointers
      _stack.Push(100);
      var newPtr = _stack.GetNodePointers().First();

      Assert.That(pointersBefore, Does.Contain(newPtr),
                  "After popping, pushing should reuse one of the previously used nodes.");
    }
  }
}


---
./LinkedHeap.Tests/LinkedHeap.Tests.csproj
---
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
    <WarningsAsErrors>Nullable</WarningsAsErrors>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>

    <IsPackable>false</IsPackable>
    <IsTestProject>true</IsTestProject>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="17.6.0" />
    <PackageReference Include="NUnit" Version="3.13.3" />
    <PackageReference Include="NUnit3TestAdapter" Version="4.2.1" />
    <PackageReference Include="NUnit.Analyzers" Version="3.6.1" />
    <PackageReference Include="coverlet.collector" Version="6.0.0" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="../LinkedHeap/LinkedHeap.csproj" />
  </ItemGroup>

</Project>


---
./LinkedHeap.Demo/App.razor
---
﻿<Router AppAssembly="@typeof(App).Assembly">
    <Found Context="routeData">
        <RouteView RouteData="@routeData" DefaultLayout="@typeof(MainLayout)" />
        <FocusOnNavigate RouteData="@routeData" Selector="h1" />
    </Found>
    <NotFound>
        <PageTitle>Not found</PageTitle>
        <LayoutView Layout="@typeof(MainLayout)">
            <p role="alert">Sorry, there's nothing at this address.</p>
        </LayoutView>
    </NotFound>
</Router>


---
./LinkedHeap.Demo/LinkedHeap.Demo.csproj
---
<Project Sdk="Microsoft.NET.Sdk.BlazorWebAssembly">

  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <Nullable>enable</Nullable>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
    <WarningsAsErrors>Nullable</WarningsAsErrors>
    <ImplicitUsings>enable</ImplicitUsings>
    <GenerateAssemblyInfo>false</GenerateAssemblyInfo>
    <OverrideHtmlAssetPlaceholders>true</OverrideHtmlAssetPlaceholders>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.Components.WebAssembly" Version="10.0.0-preview.4.25258.110" />
    <PackageReference Include="Microsoft.AspNetCore.Components.WebAssembly.DevServer" Version="10.0.0-preview.4.25258.110" PrivateAssets="all" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="../LinkedHeap/LinkedHeap.csproj" />
  </ItemGroup>

</Project>


---
./LinkedHeap.Demo/Program.cs
---
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using LinkedHeap.Demo;
using LinkedHeap;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddLinkedHeapServices<int>();

await builder.Build().RunAsync();


---
./LinkedHeap.Demo/_Imports.razor
---
﻿@using System.Net.Http
@using System.Net.Http.Json
@using Microsoft.AspNetCore.Components.Forms
@using Microsoft.AspNetCore.Components.Routing
@using Microsoft.AspNetCore.Components.Web
@using Microsoft.AspNetCore.Components.Web.Virtualization
@using Microsoft.AspNetCore.Components.WebAssembly.Http
@using Microsoft.JSInterop
@using LinkedHeap.Demo
@using LinkedHeap.Demo.Layout


---
./LinkedHeap.Demo/Pages/Index.razor
---
@page "/"
@using System.Collections.Generic
@using LinkedHeap

<h3>LinkedHeap Demo</h3>

<div class="stats-container">
  <div><b>Total Nodes:</b> @allNodes.Count</div>
  <div><b>In-Use:</b> @InUseCount</div>
  <div><b>Free:</b> @(allNodes.Count - InUseCount)</div>
</div>

<div class="controls-container">
  <fieldset class="control-group">
    <legend>Stack Controls</legend>

    <div class="control-row">
      <input type="number" @bind="customStackValue" class="value-input" />
      <button class="btn btn-primary" @onclick="() => Push(customStackValue)">
        Push Value
      </button>
      <button class="btn btn-secondary" @onclick="PopStack" disabled="@MyStack.IsEmpty">
        Pop
      </button>
      <span class="peek-label">Top: @(MyStack.IsEmpty ? "—" : MyStack.Peek().ToString())</span>
    </div>

    <div class="control-row">
      <label><input type="checkbox" @bind="autoStack" /> Auto-Stack</label>
      <span class="interval-label">Min Delay (ms):</span>
      <input type="number" @bind="stackMinDelayMs" class="interval-input" />
      <span class="interval-label">Max Delay (ms):</span>
      <input type="number" @bind="stackMaxDelayMs" class="interval-input" />
      <span class="jitter-note">Actions will occur at random intervals in this range.</span>
    </div>
  </fieldset>

  <fieldset class="control-group">
    <legend>Queue Controls</legend>

    <div class="control-row">
      <input type="number" @bind="customQueueValue" class="value-input" />
      <button class="btn btn-primary" @onclick="() => Enqueue(customQueueValue)">
        Enqueue Value
      </button>
      <button class="btn btn-secondary" @onclick="DequeueQueue" disabled="@MyQueue.IsEmpty">
        Dequeue
      </button>
      <span class="peek-label">Front: @(MyQueue.IsEmpty ? "—" : MyQueue.Peek().ToString())</span>
    </div>

    <div class="control-row">
      <label><input type="checkbox" @bind="autoQueue" /> Auto-Queue</label>
      <span class="interval-label">Min Delay (ms):</span>
      <input type="number" @bind="queueMinDelayMs" class="interval-input" />
      <span class="interval-label">Max Delay (ms):</span>
      <input type="number" @bind="queueMaxDelayMs" class="interval-input" />
      <span class="jitter-note">Actions will occur at random intervals in this range.</span>
    </div>
  </fieldset>
</div>

<h4>All Heap Nodes (grid):</h4>
<div class="heap-grid">
  @foreach (var ptr in allNodes)
  {
    unsafe
    {
      <div class="heap-cell @(IsInUse(ptr) ? "used" : "free")">
        <div><b>Ptr:</b> @ptr.ToString("X")</div>
        @if (IsInUse(ptr))
        {
          <div><b>Val:</b> @GetValue(ptr)</div>
          @if (GetNext(ptr) == null)
          {
            <div><b>Next:</b> null</div>
          }
          else
          {
            <div><b>Next:</b> @(((IntPtr)GetNext(ptr)).ToString("X"))</div>
          }
        }
        else
        {
          <div class="free-label"><i>free</i></div>
        }
      </div>
    }
  }
</div>


---
./LinkedHeap.Demo/Pages/Index.razor.cs
---
using Microsoft.AspNetCore.Components;

namespace LinkedHeap.Demo.Pages
{
  /// <summary>
  /// Code‐behind for <c>Index.razor</c>.
  /// Manages stack/queue controls, automated random operations, and rendering of heap nodes.
  /// </summary>
  public partial class Index : ComponentBase, IDisposable
  {
    /// <summary>
    /// All raw node pointers (one per allocated block, free or in‐use).
    /// </summary>
    private List<IntPtr> allNodes = [];

    /// <summary>
    /// Number to push onto the stack when "Push Value" is clicked.
    /// </summary>
    private int customStackValue = 0;

    /// <summary>
    /// Number to enqueue into the queue when "Enqueue Value" is clicked.
    /// </summary>
    private int customQueueValue = 0;

    /// <summary>
    /// Whether auto‐stack mode is enabled (random push/pop).
    /// </summary>
    private bool autoStack = false;

    /// <summary>
    /// Minimum millisecond delay between random stack actions.
    /// </summary>
    private int stackMinDelayMs = 100;

    /// <summary>
    /// Maximum millisecond delay between random stack actions.
    /// </summary>
    private int stackMaxDelayMs = 300;

    /// <summary>
    /// Whether auto‐queue mode is enabled (random enqueue/dequeue).
    /// </summary>
    private bool autoQueue = false;

    /// <summary>
    /// Minimum millisecond delay between random queue actions.
    /// </summary>
    private int queueMinDelayMs = 100;

    /// <summary>
    /// Maximum millisecond delay between random queue actions.
    /// </summary>
    private int queueMaxDelayMs = 300;

    /// <summary>
    /// Cancellation token source for the stack‐monitoring background loop.
    /// </summary>
    private CancellationTokenSource? ctsStack;

    /// <summary>
    /// Cancellation token source for the queue‐monitoring background loop.
    /// </summary>
    private CancellationTokenSource? ctsQueue;

    /// <summary>
    /// Current count of in‐use nodes.
    /// Computed whenever <see cref="RefreshHeap"/> is called.
    /// </summary>
    private int InUseCount { get; set; } = 0;

    /// <summary>
    /// The <see cref="IHeap{int}"/> instance resolved from DI.
    /// </summary>
    [Inject]
    public IHeap<int> MyHeap { get; set; } = default!;

    /// <summary>
    /// The <see cref="IStack{int}"/> instance resolved from DI, backed by the same unmanaged heap.
    /// </summary>
    [Inject]
    public IStack<int> MyStack { get; set; } = default!;

    /// <summary>
    /// The <see cref="IQueue{int}"/> instance resolved from DI, backed by the same unmanaged heap.
    /// </summary>
    [Inject]
    public IQueue<int> MyQueue { get; set; } = default!;

    #region Lifecycle

    /// <summary>
    /// Called when the component is initialized. Hooks heap events and starts background loops.
    /// </summary>
    protected override void OnInitialized()
    {
      // Subscribe to heap allocate/free to refresh UI
      MyHeap.OnAllocate += _ => RefreshHeap();
      MyHeap.OnFree += _ => RefreshHeap();
      RefreshHeap();

      // Start the stack loop
      ctsStack = new CancellationTokenSource();
      _ = MonitorStackAsync(ctsStack.Token);

      // Start the queue loop
      ctsQueue = new CancellationTokenSource();
      _ = MonitorQueueAsync(ctsQueue.Token);
    }

    /// <summary>
    /// Dispose of cancellation token sources when the component is destroyed.
    /// </summary>
    public void Dispose()
    {
      ctsStack?.Cancel();
      ctsQueue?.Cancel();
      GC.SuppressFinalize(this);
    }

    #endregion

    #region Heap Refresh

    /// <summary>
    /// Re‐reads all raw node pointers and updates <see cref="allNodes"/> and <see cref="InUseCount"/>.
    /// Triggers a UI re‐render.
    /// </summary>
    private void RefreshHeap()
    {
      allNodes = [.. MyHeap.GetAllNodes()];
      InUseCount = allNodes.Count(IsInUse);
      InvokeAsync(StateHasChanged);
    }

    #endregion

    #region Stack Operations

    /// <summary>
    /// Pushes a single <paramref name="value"/> onto the stack.
    /// Fired when "Push Value" button is clicked.
    /// </summary>
    /// <param name="value">The integer to push onto <see cref="MyStack"/>.</param>
    private void Push(int value)
    {
      MyStack.Push(value);
    }

    /// <summary>
    /// Pops the top element from <see cref="MyStack"/> if not empty.
    /// Fired when “Pop” button is clicked.
    /// </summary>
    private void PopStack()
    {
      if (!MyStack.IsEmpty)
        MyStack.Pop();
    }

    /// <summary>
    /// Background loop that, while <paramref name="token"/> is not canceled:
    /// – Randomly chooses to push or pop (50/50) if <see cref="autoStack"/>
    /// – Waits a random delay between <see cref="stackMinDelayMs"/> and <see cref="stackMaxDelayMs"/> ms
    /// </summary>
    /// <param name="token">Cancellation token for stopping the loop.</param>
    private async Task MonitorStackAsync(CancellationToken token)
    {
      var rnd = new Random();
      while (!token.IsCancellationRequested)
      {
        if (autoStack)
        {
          // 50% chance to Push a random value; otherwise Pop if possible
          if (rnd.NextDouble() < 0.5)
          {
            int val = rnd.Next(0, 100);
            MyStack.Push(val);
          }
          else if (!MyStack.IsEmpty)
          {
            MyStack.Pop();
          }
        }

        // Wait a random interval
        int delay = rnd.Next(stackMinDelayMs, stackMaxDelayMs + 1);
        try
        {
          await Task.Delay(delay, token);
        }
        catch (TaskCanceledException)
        {
          return;
        }
      }
    }

    #endregion

    #region Queue Operations

    /// <summary>
    /// Enqueues a single <paramref name="value"/> into <see cref="MyQueue"/>.
    /// Fired when “Enqueue Value” button is clicked.
    /// </summary>
    /// <param name="value">The integer to enqueue.</param>
    private void Enqueue(int value)
    {
      MyQueue.Enqueue(value);
    }

    /// <summary>
    /// Dequeues the front element from <see cref="MyQueue"/> if not empty.
    /// Fired when “Dequeue” button is clicked.
    /// </summary>
    private void DequeueQueue()
    {
      if (!MyQueue.IsEmpty)
        MyQueue.Dequeue();
    }

    /// <summary>
    /// Background loop that, while <paramref name="token"/> is not canceled:
    /// – Randomly chooses to enqueue or dequeue (50/50) if <see cref="autoQueue"/>
    /// – Waits a random delay between <see cref="queueMinDelayMs"/> and <see cref="queueMaxDelayMs"/> ms
    /// </summary>
    /// <param name="token">Cancellation token for stopping the loop.</param>
    private async Task MonitorQueueAsync(CancellationToken token)
    {
      var rnd = new Random();
      while (!token.IsCancellationRequested)
      {
        if (autoQueue)
        {
          // 50% chance to Enqueue a random value; otherwise Dequeue if possible
          if (rnd.NextDouble() < 0.5)
          {
            int val = rnd.Next(0, 100);
            MyQueue.Enqueue(val);
          }
          else if (!MyQueue.IsEmpty)
          {
            MyQueue.Dequeue();
          }
        }

        // Wait a truly random interval
        int delay = rnd.Next(queueMinDelayMs, queueMaxDelayMs + 1);
        try
        {
          await Task.Delay(delay, token);
        }
        catch (TaskCanceledException)
        {
          return;
        }
      }
    }

    #endregion

    #region Pointer Helpers (unsafe)

    /// <summary>
    /// Reads the raw <see cref="HeapNode{T}.InUse"/> byte from unmanaged memory and returns true if allocated.
    /// </summary>
    /// <param name="ptr">Pointer (as <see cref="IntPtr"/>) to a <see cref="HeapNode{int}"/>.</param>
    /// <returns><c>true</c> if this node’s InUse flag is 1; otherwise <c>false</c>.</returns>
    private unsafe bool IsInUse(IntPtr ptr)
    {
      return ((HeapNode<int>*)ptr)->InUse == 1;
    }

    /// <summary>
    /// Reads the raw <see cref="HeapNode{T}.Value"/> from unmanaged memory.
    /// </summary>
    /// <param name="ptr">Pointer (as <see cref="IntPtr"/>) to a <see cref="HeapNode{int}"/>.</param>
    /// <returns>The integer payload stored in that node.</returns>
    private unsafe int GetValue(IntPtr ptr)
    {
      return ((HeapNode<int>*)ptr)->Value;
    }

    /// <summary>
    /// Reads the raw <see cref="HeapNode{T}.Next"/> pointer from unmanaged memory.
    /// </summary>
    /// <param name="ptr">Pointer (as <see cref="IntPtr"/>) to a <see cref="HeapNode{int}"/>.</param>
    /// <returns>
    /// A <see cref="HeapNode{int}*"/> pointing to the next node (free‐list or stack/queue link),
    /// or <c>null</c>.
    /// </returns>
    private unsafe HeapNode<int>* GetNext(IntPtr ptr)
    {
      return ((HeapNode<int>*)ptr)->Next;
    }

    #endregion
  }
}


---
./LinkedHeap.Demo/Properties/launchSettings.json
---
{
  "$schema": "https://json.schemastore.org/launchsettings.json",
  "profiles": {
    "https": {
      "commandName": "Project",
      "dotnetRunMessages": true,
      "launchBrowser": true,
      "inspectUri": "{wsProtocol}://{url.hostname}:{url.port}/_framework/debug/ws-proxy?browser={browserInspectUri}",
      "applicationUrl": "https://localhost:7106;http://localhost:5097",
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    }
  }
}


---
./LinkedHeap.Demo/Layout/MainLayout.razor
---
﻿@inherits LayoutComponentBase
<div class="page">
  <main>
    <div class="top-row px-4">
      <a href="https://github.com/Hier0nim/LinkedHeap" target="_blank">Github</a>
    </div>

    <article class="content px-4">
      @Body
    </article>
  </main>
</div>


---
./LinkedHeap.Demo/wwwroot/index.html
---
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>LinkedHeap.Demo</title>
    <base href="/" />
    <link rel="preload" id="webassembly" />
    <link rel="stylesheet" href="lib/bootstrap/dist/css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/app.css" />
    <link rel="icon" type="image/png" href="favicon.png" />
    <link href="LinkedHeap.Demo.styles.css" rel="stylesheet" />
    <script type="importmap"></script>
</head>

<body>
    <div id="app">
        <svg class="loading-progress">
            <circle r="40%" cx="50%" cy="50%" />
            <circle r="40%" cx="50%" cy="50%" />
        </svg>
        <div class="loading-progress-text"></div>
    </div>

    <div id="blazor-error-ui">
        An unhandled error has occurred.
        <a href="." class="reload">Reload</a>
        <span class="dismiss">🗙</span>
    </div>
    <script src="_framework/blazor.webassembly#[.{fingerprint}].js"></script>
</body>

</html>


---
./LinkedHeap.Demo/wwwroot/sample-data/weather.json
---
﻿[
  {
    "date": "2022-01-06",
    "temperatureC": 1,
    "summary": "Freezing"
  },
  {
    "date": "2022-01-07",
    "temperatureC": 14,
    "summary": "Bracing"
  },
  {
    "date": "2022-01-08",
    "temperatureC": -13,
    "summary": "Freezing"
  },
  {
    "date": "2022-01-09",
    "temperatureC": -16,
    "summary": "Balmy"
  },
  {
    "date": "2022-01-10",
    "temperatureC": -2,
    "summary": "Chilly"
  }
]


---
