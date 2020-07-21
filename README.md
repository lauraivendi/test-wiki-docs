# test-wiki-docs

This is a demo of automatically generating documentation from [in-code comments](https://docs.microsoft.com/en-us/dotnet/csharp/codedoc) and putting it in the github wiki

It uses the nuget package [Vsxmd](https://github.com/lijunle/Vsxmd) to convert the xml files into `.md` files and put them in `docs/wiki` when you build the project

And then uses an [action](https://github.com/lauraivendi/test-wiki-docs/blob/master/.github/workflows/main.yml) to trigger generating the wiki on commit

The action uses [setup-dotnet](https://github.com/actions/setup-dotnet) to build the project (although I'm not sure the next step uses any changes this build might create)

And then uses [wiki-page-creator-action](https://github.com/Decathlon/wiki-page-creator-action) to copy any markdown files from `docs/wiki` to the wiki. Requires a github access token to commit to the wiki
