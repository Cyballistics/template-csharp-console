# Overview

A template, free to use to get your console applications bootstraped with unit testing included.

## Fluent Assertions

Inspect the `.csproj` files, you will notice the `XUnit` and `FluentAssertions` Libraries included in the `template-tests`.  This is to aid or encourage you to not only write good software, but to build excellent software with unit tests.

## How to use
Essentially, clone this repo, then install the template locally, and then use the templete for your projects.

### Step 1 - Git Clone

```bash
git clone https://github.com/Cyballistics/template-csharp-console.git
```

### Step 2 - Install Template

```bash
## Navigate into the cloned repo first
dotnet new --install .
```

### Step 3 - Use it

```bash
dotnet new mytemplate -n NewProjectName
```