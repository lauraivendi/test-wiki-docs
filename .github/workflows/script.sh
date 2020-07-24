#!/bin/bash

log=$(git log -- src/Application)

changelog=$'# iVendi.Stock Changelog\n\n'

readarray -t lines <<<"$log"

for line in "${lines[@]}"
do	
	if [[ $line == commit* ]] ;
	then
		commithash=$(echo $line| cut -d' ' -f 2)
	fi

	if [[ $line == Author* ]] ;
	then
		authorPart=$(echo $line| cut -d'<' -f 1)
		author=$(echo $authorPart| cut -d':' -f 2)
		email=$(echo $line| cut -d'<' -f 2)
	fi

	if [[ $line == Date* ]] ;
	then
		dateString=${line#"Date:   "}
	fi

	if [[ $line == "    "* ]] ;
	then
		changelog+=$"* ${line#"    "}"
		changelog+=$'\n'
		changelog+=$"    * [$commithash](https://github.com/lauraivendi/test-wiki-docs/commit/$commithash)"
		changelog+=$'\n'
		changelog+=$"    * [${author#" "}](mailto:${email%">"})"
		changelog+=$'\n'
		changelog+=$"    * ${dateString}"
		changelog+=$'\n\n'
	fi
done

echo "${changelog}" > docs/wiki/iVendi.Stock-changelog.md