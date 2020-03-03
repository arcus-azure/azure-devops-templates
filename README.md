# Azure DevOps YAML Templates
Collection of Azure DevOps YAML Templates used to build & ship Arcus.

## Build

- [Build Solution](build/build-solution.yml): compiles a solution for either a preview or official version.

## GitHub

- [Create Release](github/create-release.yml): create a new GitHub official ore release on a given repository based on the provided version.

## Test

- [Run Unit Tests](test/run-unit-tests.yml): run a set of unit tests; without replacing any application tokens with settings.
- [Run Integration Tests](test/run-integration-tests.yml): run a set of integration tests within a specified category by replacing required tokens with real application settings.

## NuGet

- [Determine Pull Request Version](nuget/determine-pr-version.yml): determines the package version based on the build number into a YAML variable called `$(packageVersion)`.
- [Publish Preview NuGet Package](nuget/publish-preview-package.yml): allows you to push a preview NuGet package to our internal feed.
- [Publish Official NuGet Package](nuget/publish-official-package.yml): allows you to push a new official NuGet package to our external feed.
