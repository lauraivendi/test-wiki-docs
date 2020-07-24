#!/bin/bash

log=$(git log -- src/Application)

echo "${log}" > docs/wiki/iVendi.Stock-changelog.md