# ScienceManager
Используемая база данных - PostgreSQL,
Перед началом работы выполните скрипты миграции таблиц базы данных (вы можете найти их в текстовом файле InitializeTablePostgreSQL.txt),
Перед запуском приложения в App.config  поменять значение connectionString данных по которым должна осуществляться работа с базой данных (строка 11)
	<appSettings>
        <add key="connectionString" value="Server=localhost;User Id=postgres;Password=123;Database=science_manager;"/>
    </appSettings>


