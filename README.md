Folder structure

Although there is no single way to organize a Unity project, here are some key recommendations:

Document your naming conventions and folder structure. A style guide and/or project template makes files easier to locate and organize. Pick what works for your team, and make sure that everyone is on board with it.
Be consistent with your naming conventions. Don’t deviate from your chosen style guide or template. If you do need to amend your naming rules, parse and rename your affected assets all at once. If ever the changes affect a large number of files, consider automating the update using a script.
Don’t use spaces in file and folder names. Unity’s command line tools have issues with path names that include spaces. Use CamelCase as an alternative for spaces.
Separate testing or sandbox areas. Create a separate folder for nonproduction scenes and experimentation. Subfolders with usernames can divide your work area by team member.
Avoid extra folders at the root level. In general, store your content files within the Assets folder. Don’t create additional folders at the project’s root level unless it’s absolutely necessary.
Keep your internal assets separate from third-party ones. If you’re using assets from the Asset Store or other plug-ins, odds are that they have their own project structure. Keep your own assets separate.
Note: If you find yourself modifying a third-party asset or plug-in for your project, then version control can help you get the latest update for the plug-in. Once the update is imported, you can look through the diff to see where your modifications might have been overwritten, and reimplement them.

Unity Attributes

Attributes are markers that can be placed above a class, property, or function in a script to indicate a special behavior.
Attributes can apply to variables, functions, or even an entire class.
It helps you create write more efficient and flexible code.
For example, you can assign a float value using a slider and show private variables in the Inspector.
