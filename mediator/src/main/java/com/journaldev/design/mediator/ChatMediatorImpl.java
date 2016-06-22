package com.journaldev.design.mediator;


/**
 * Created by ericleijonmarck on 2016-06-22.
 */

import java.util.ArrayList;
import java.util.List;

public class ChatMediatorImpl implements ChatMediator {

    private List<User> users;
    public ChatMediatorImpl(){
        this.users = new ArrayList<User>();
    }

    @Override
    public void sendMessage(String msg, User user) {
        for(User u : this.users){
            if(u != user){
                u.receive(msg);
            }
        }
    }

    @Override
    public void addUser(User user) {
        this.users.add(user);
    }
}

