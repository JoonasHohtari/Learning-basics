from tkinter import *

window = Tk()

entry = Entry(window, 
              font=("Arial", 50),
              fg="#00FF00",
              bg="black",
              show="*",)

entry.insert(0,"Hello")
entry.pack(side=LEFT)

submit_button = Button(window,text="Submit",command=lambda:(print(entry.get()),entry.config(state=DISABLED)))
submit_button.pack(side=RIGHT)

delete_button = Button(window,text="Delete",command=lambda:entry.delete(0,END))
delete_button.pack(side=RIGHT)

backspace_button = Button(window,text="Backspace",command=lambda:entry.delete(len(entry.get())-1,END))
backspace_button.pack(side=RIGHT)

window.mainloop()