#!/bin/bash
#necesita root
chcon -t system_cron_spool_t /etc/crontab
systemctl start crond > /dev/null 2>&1