# github-release-workflow-demo

This is just a demo of a release workflow for a .NET library.

The `DummyLib` doesn't do a thing so don't bother. 😅

## Repository Content

* `build/BuildPipeline`: NUKE project for building, testing, and releasing the `DummyLib`
* `src/DummyLib/`: the dummy .NET library project to be released
* `tests/DummyLib.Test/`: unit-tests for `DummyLib`
* `.github/`: configuration and workflow related to GitHub

## Conventions and Release Strategy

The repository uses `main` as the default branch. Changes to the repository should happen on dedicated branches and with PRs. Every PR should be tagged, e.g. with `enhancement`, and have a sensible title.

The usage of conventional commits is optional.

The project has always a draft release titled `vNext`. After merging a PR the release notes of the draft release will be updated. The title of the PR will be added to the release notes as is. The title will also be categorized based on the PR tags, e.g. a PR tagged with `enhancement` will be listed as `Feature`.

The repository contains a `CHANGELOG.md` containing all releases.

Releasing the project builds the `DummyLib`, creates a GitHub release, and updates the `CHANGELOG.md` with the release notes from the draft release. The new GitHub release is marked as `latest`. Release must be triggered manually and a semantic version must be provided.

The created NuGet package will _not_ be released for the purpose of this demo.

## GitHub Workflows

The repository includes these GitHub workflows:

* `.github/workflows/ci.yml`: basic workflow that builds `DummyLib` and runs the unit-tests triggered by every commit. If this workflow fails, merging a PR should be blocked.
* `.github/workflows/update-draft.yml`: workflow for maintaining the draft release, triggered by every commit on `main`.
* `.github/workflows/release-pr-based.yml`: release workflow to be triggered manually. A semantic version must be provided. This is where all the magic happens.
* `.github/workflows/release-commit-based.yml`: first draft of a release workflow. Must be triggered manually and uses a semantic version for the release. `CHANGELOG.md` will be updated based on conventional commits. Every commit is added to the changelog, so PR commits are best squashed.

## So... what now?

I created this project to test GitHub workflows and to develop a release strategy for .NET library projects without messing up an _actual_ project.

So if something of this repository is helpful to you, good on you. If it is not, well see you next time.

## License

MIT License - see [LICENSE](./LICENSE) for more information.