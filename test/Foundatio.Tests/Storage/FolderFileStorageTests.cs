﻿using System.Threading.Tasks;
using Foundatio.Storage;
using Xunit;
using Xunit.Abstractions;

namespace Foundatio.Tests.Storage {
    public class FolderFileStorageTests : FileStorageTestsBase {
        public FolderFileStorageTests(ITestOutputHelper output) : base(output) {}

        protected override IFileStorage GetStorage() {
            return new FolderFileStorage("temp");
        }

        [Fact]
        public override Task CanGetEmptyFileListOnMissingDirectory() {
            return base.CanGetEmptyFileListOnMissingDirectory();
        }

        [Fact]
        public override Task CanGetFileListForSingleFolder() {
            return base.CanGetFileListForSingleFolder();
        }

        [Fact]
        public override Task CanSaveFilesAsync() {
            return base.CanSaveFilesAsync();
        }

        [Fact]
        public override Task CanManageFiles() {
            return base.CanManageFiles();
        }

        [Fact]
        public override Task CanConcurrentlyManageFiles() {
            return base.CanConcurrentlyManageFiles();
        }
        
#if !NETSTANDARD
        [Fact]
        public override void CanUseDataDirectory() {
            base.CanUseDataDirectory();
        }
#endif
    }
}
