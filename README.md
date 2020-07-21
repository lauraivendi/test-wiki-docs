# test-wiki-docs

This is a demo of automatically generating documentation from [in-code comments](https://docs.microsoft.com/en-us/dotnet/csharp/codedoc) and putting it in the github wiki

It uses the nuget package [Vsxmd](https://github.com/lijunle/Vsxmd) to convert the xml files into `.md` files and put them in `docs/wiki` when you build the project

And then uses an [action](https://github.com/lauraivendi/test-wiki-docs/blob/master/.github/workflows/main.yml) to trigger generating the wiki on commit

The action uses [setup-dotnet](https://github.com/actions/setup-dotnet) to build the project (although I'm not sure the next step uses any changes this build might create)

And then uses [wiki-page-creator-action](https://github.com/Decathlon/wiki-page-creator-action) to copy any markdown files from `docs/wiki` to the wiki. Requires a github access token to commit to the wiki


Pros:

* Easy to keep updated when you change the code
* No need to remember to update docs in another place
* Otherwise is all automated, no manual steps

Cons:

* If you don't build before committing it'll be out of date as I think the wiki page creator code pulls fresh from the repo
* The comments in code can make classes look horrific :vom:


This is intended to be used for a nuget package or an API (internal use)
