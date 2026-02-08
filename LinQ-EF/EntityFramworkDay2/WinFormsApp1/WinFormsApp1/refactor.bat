@echo off
echo Refactoring Project Structure...

if not exist Forms mkdir Forms

echo Moving Form files...
move AddBook.* Forms\
move BookDetails.* Forms\
move Home.* Forms\
move Login.* Forms\
move Profile.* Forms\
move Registration.* Forms\
move Form1.* Forms\

echo Moving Control files...
move Card.* Controls\

echo Done! The project structure has been updated.
pause
