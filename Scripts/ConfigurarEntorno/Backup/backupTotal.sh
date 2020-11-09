#!/bin/bash

BACKUP="/var/bytesoft/backupsTotales/BD/backupBD"

# Respaldo de la base de datos
mysqldump --defaults-file=/var/bytesoft/backupsBD/.credenciales.cnf --all-databases > "$BACKUP.sql"
tar -czf "$BACKUP.sql.tar.gz" "$BACKUP.sql"
rm -f $BACKUP.sql

# Respaldo de los logs
tar -czf "/var/bytesoft/backupsTotales/Logs/backupLog.tar.gz" /var/log

# Respaldo de los directorios
tar -czf "/var/bytesoft/backupsTotales/DIR/backupDIR.tar.gz" /home/USUARIOS

# Envío los datos al servidor remoto
rsync -az -e "ssh -p 2022" "/var/bytesoft" bytesoftRespaldo@$IP_RESPALDO:/var/bytesoft # IP de prueba