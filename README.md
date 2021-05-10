A simple progress report viewer and editor for my CITC Capstone class. It's written in C#, and uses winforms and SQL.
It loads and saves the reports to a database (the original used a live SQL server, this one saves to a local .mbd file), and allows for the creation, deletion, and editing of reports.
It prompts the user to save or cancel any changes made before switching reports, to avoid lost work. It also propts on save/delete.
Reports can either be searched by text content, or filtered by the report's interval (e.g. daily, weekly, monthly, etc).

![Report Editor - main screen](https://user-images.githubusercontent.com/83547705/117720007-be92a800-b1a3-11eb-8484-717931008056.png)

![Report Editor - unsaved changes](https://user-images.githubusercontent.com/83547705/117720039-c5b9b600-b1a3-11eb-80cd-63c7d9ff95c9.png)

![Report Editor - delete prompt](https://user-images.githubusercontent.com/83547705/117720047-c8b4a680-b1a3-11eb-84eb-0fe25c365866.png)

This project is released under a GPL3+ license.
