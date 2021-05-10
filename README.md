A simple progress report viewer and editor for my CITC Capstone class. It's written in C#, and uses winforms and SQL.
It loads and saves the reports to a database (the original used a live SQL server, this one saves to a local .mbd file), and allows for the creation, deletion, and editing of reports.
It prompts the user to save or cancel any changes made before switching reports, to avoid lost work. It also propts on save/delete.
Reports can either be searched by text content, or filtered by the report's interval (e.g. daily, weekly, monthly, etc).




This project is released under a GPL3+ license.
