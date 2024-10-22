module.exports = (sequelize, DataTypes) => {
    const Posts = sequelize.define('Posts', {
        title: ({
            title: DataTypes.STRING,
            allowNull: false
        }),
        postText: ({
            title: DataTypes.STRING,
            allowNull: false
        }),
        username: ({
            title: DataTypes.STRING,
            allowNull: false
        })
    });

    return Posts;
};