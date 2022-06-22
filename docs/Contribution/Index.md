# Contribution Guide

---
This guide is for people who are new to contributing to the project.

## Code contributions

---
You can contribute to the project by making a pull request on our Github repository.

* [Fork](https://docs.github.com/en/get-started/quickstart/fork-a-repo) the repository
  from [Github](https://github.com/corpsolutions/Streamteam)
* [Create a new branch](https://docs.github.com/en/git/branches/branch-creation-and-merging)
* Make the necessary changes to the code, including tests
* [Commit your changes](https://docs.github.com/en/git/committing-and-merging-merge-methods/commit-changes)
* [Push your branch](https://docs.github.com/en/git/commands/push-to-github/push-a-branch-to-github)
* [Create a pull request](https://docs.github.com/en/github/collaborating-with-issues-and-pull-requests/open-a-pull-request)

> When you open a solution in Visual Studio, you may need to execute dotnet restore in the root folder of the solution
> for one time, after it is fully opened in the Visual Studio. This is needed since VS can't properly resolves local
> references to projects out of the solution.

## Bug reports

If you find a bug, please [report](https://github.com/corpsolutions/Streamteam/issues/new) it on our Github repository.

## Branching scheme is based on the following principles:

- All features are developed in the feature branch.
- Testings are done in the feature branch.
- **Merge** used if the feature branch is merged into the main branch. Before merging, need to perform **rebase** to the
  main branch and run **squash**.
- For all pull-ups other branches, using `git rebase -i` to rebase the feature branch to the main branch. Good practice
  described by [here](https://mindmajix.com/about-git-rebase).
- Hotfix and other changes that do not require testing merging into the main branch.

## The naming convention for branches is:

When naming branches, letters, numbers and the "-" sign are used.
**Naming Template**: `<a short description of the feature>`. For example: `add-new-feature`.

### **Note:** Useful links:

- [Book of Git](https://git-scm.com/book):