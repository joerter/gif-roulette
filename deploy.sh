#! /bin/bash

rsync ./docker-compose.production.yml chat@gifroulette.johnoerter.me:/home/chat
ssh chat@gifroulette.johnoerter.me docker-compose -f docker-compose.production.yml stop
ssh chat@gifroulette.johnoerter.me docker pull joerter/gifroulette:latest
ssh chat@gifroulette.johnoerter.me docker-compose -f docker-compose.production.yml up -d
