$TestRecordingFile = Join-Path 'C:\zd\azure-powershell\src\Storage\test' 'Set-AzStorageFileContent!V2.Recording.json'
. (Join-Path $PSScriptRoot '..\generated\runtime' 'HttpPipelineMocking.ps1')

Describe 'Set-AzStorageFileContent!V2' {
    It 'ShareName' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Share' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Directory' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}